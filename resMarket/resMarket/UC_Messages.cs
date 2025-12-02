using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace resMarket
{
    public partial class UC_Messages : UserControl
    {
        private int currentUserId = 0;
        private int receiverId = 0;
        private string connStr = "Server=LILLY\\SQLEXPRESS;Database=resMarketDB;Trusted_Connection=True;";

        private Timer refreshTimer;  
        private int lastLoadedUserId = 0; 

        public UC_Messages()
        {
            InitializeComponent();
        }

        public UC_Messages(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
        }

        public UC_Messages(int userId, int sellerId)
        {
            InitializeComponent();
            currentUserId = userId;
            receiverId = sellerId;
        }

        private void UC_Messages_Load(object sender, EventArgs e)
        {
          lstConversations.Items.Clear();

            if (currentUserId > 0)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        string sql = @"
                    SELECT DISTINCT u.UserID, u.FullName
                    FROM Users u
                    WHERE u.UserID <> @UID
                      AND EXISTS (
                          SELECT 1 FROM Messages m
                          WHERE (m.SenderID = @UID AND m.ReceiverID = u.UserID)
                             OR (m.SenderID = u.UserID AND m.ReceiverID = @UID)
                      )";

                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@UID", currentUserId);
                            conn.Open();

                            SqlDataReader reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                lstConversations.Items.Add(new ListItem(
                                    reader["FullName"].ToString(),
                                    Convert.ToInt32(reader["UserID"])
                                ));
                            }
                        }

                        if (receiverId > 0)
                        {
                            bool found = false;
                            foreach (var item in lstConversations.Items)
                            {
                                if (item is ListItem li && li.Id == receiverId)
                                {
                                    lstConversations.SelectedItem = li;
                                    found = true;
                                    break;
                                }
                            }

                            if (!found)
                            {
                                lstConversations.Items.Add(new ListItem("Seller", receiverId));
                                lstConversations.SelectedIndex = lstConversations.Items.Count - 1;
                            }

                            LoadChat(receiverId);
                            lastLoadedUserId = receiverId;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading conversations: " + ex.Message);
                }
                MessageBox.Show($"DEBUG: currentUserId = {currentUserId}, receiverId = {receiverId}");
            }

            lstConversations.DisplayMember = "Name";
            lstConversations.SelectedIndexChanged += LstConversations_SelectedIndexChanged;

            refreshTimer = new Timer();
            refreshTimer.Interval = 3000;
            refreshTimer.Tick += RefreshTimer_Tick;
            refreshTimer.Start();
        }

        private void LstConversations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstConversations.SelectedItem is ListItem selectedUser)
            {
                LoadChat(selectedUser.Id);
                lastLoadedUserId = selectedUser.Id; 
            }
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            if (lastLoadedUserId > 0)
            {
                LoadChat(lastLoadedUserId);
            }
        }

        private void LoadChat(int otherUserId)
        {
            flowChat.Controls.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string sql = @"
                        SELECT SenderID, MessageText, SentAt
                        FROM Messages
                        WHERE (SenderID = @UID AND ReceiverID = @OtherID)
                           OR (SenderID = @OtherID AND ReceiverID = @UID)
                        ORDER BY SentAt ASC";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@UID", currentUserId);
                        cmd.Parameters.AddWithValue("@OtherID", otherUserId);

                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            bool isMine = Convert.ToInt32(reader["SenderID"]) == currentUserId;
                            string text = reader["MessageText"].ToString();

                            Label msg = new Label();
                            msg.AutoSize = true;
                            msg.MaximumSize = new Size(400, 0);
                            msg.Text = text;
                            msg.BackColor = isMine ? Color.LightGreen : Color.LightGray;
                            msg.Padding = new Padding(8);
                            msg.Margin = new Padding(5);

                            flowChat.Controls.Add(msg);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading chat: " + ex.Message);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            int targetId = receiverId;

            if (lstConversations.SelectedItem is ListItem selectedUser)
                targetId = selectedUser.Id;

            if (!string.IsNullOrWhiteSpace(txtMessage.Text) && targetId > 0)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        
                        string sql = @"INSERT INTO Messages (SenderID, ReceiverID, MessageText, SentAt)
                                       VALUES (@SenderID, @ReceiverID, @Text, GETDATE())";

                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@SenderID", currentUserId);
                            cmd.Parameters.AddWithValue("@ReceiverID", targetId);
                            cmd.Parameters.AddWithValue("@Text", txtMessage.Text);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }

                    LoadChat(targetId);
                    lastLoadedUserId = targetId;
                    txtMessage.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error sending message: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a conversation first.");
            }
        }

        private void pnlChatArea_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowChat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lstConversations_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void pnlConversations_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    public class ListItem
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public ListItem(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}