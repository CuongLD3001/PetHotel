using QuanLyShop.DAO;
using QuanLyShop.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShop
{
    public partial class fRoomManager : Form
    {
        public fRoomManager()
        {
            InitializeComponent();
            loadRoom();
            loadCategory();
            LoadComboBoxRoom(cbSwitch);
        }

        #region Method

        void loadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbCategory.ValueMember = "Id";
            cbCategory.DisplayMember = "Name";
            cbCategory.DataSource = listCategory;
        } 

        void loadPetListByCategoryID(int id)
        {
            Console.WriteLine(id);
            List<Pet> listPet = PetDAO.Instance.GetPetByCategoryId(id);
            cbPet.DataSource = listPet;
            cbPet.ValueMember = "Id";
            cbPet.DisplayMember = "Name";
        }

        void loadRoom()
        {
            flpRoom.Controls.Clear();
            List<Room> roomList = RoomDAO.Instance.LoadRoomList();
            foreach(Room item in roomList)
            {
                Button btn = new Button() { Width = RoomDAO.RoomWidth, Height = RoomDAO.RoomHeight };
                btn.Text= item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag=item;

                switch (item.Status)
                {
                    case "Trong":
                        btn.BackColor = Color.Green;
                        break;
                    default:
                        btn.BackColor = Color.Yellow;
                        break;
                }
                flpRoom.Controls.Add(btn);
            }
        }

        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach (Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.PetName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice+= item.TotalPrice;
                lsvBill.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            txbTotalPrice.Text = totalPrice.ToString("c");
           
        }

        void LoadComboBoxRoom(ComboBox cb)
        {
            cb.DataSource = RoomDAO.Instance.LoadRoomList();
            cb.DisplayMember = "Name";
        }

        #endregion






        #region Events

        private void btn_Click(object sender, EventArgs e)
        {
            int RoomID = ((sender as Button).Tag as Room).Id;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(RoomID);
        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void personalInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile();
            f.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
        }
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPetListByCategoryID((int)cbCategory.SelectedValue);
        }

        private void btnAddPet_Click(object sender, EventArgs e)
        {
            Room room = lsvBill.Tag as Room;

            int idBill = BillDAO.Instance.GetUncheckBillIDByRoomID(room.Id);
            int petId = (cbPet.SelectedItem as Pet).Id;
            int count = (int)nmPetCount.Value;

            if(idBill == -1)
            {
                BillDAO.Instance.InsertBill(room.Id);      
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), petId, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, petId, count);
            }
         
            ShowBill(room.Id);
            loadRoom();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            Room room = lsvBill.Tag as Room;
            int idBill = BillDAO.Instance.GetUncheckBillIDByRoomID(room.Id);
            int discount = (int)nmDiscount.Value;

            double totalPrice = Convert.ToDouble(txbTotalPrice.Text.Split(',')[0]);
            double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;
            if(idBill != -1)
            {
                if(MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho phòng {0}\n Tổng tiền - (Tổng tiền / 100) x Giảm giá\n => {1} - ({1} / 100) x {2} = {3}",room.Name, totalPrice, discount, finalTotalPrice), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill, discount);
                    ShowBill(room.Id);
                    loadRoom();
                }
            }
        }
        private void btnSwitchPet_Click(object sender, EventArgs e)
        {
            int id1 = (lsvBill.Tag as Room).Id;

            int id2 = (cbSwitch.SelectedItem as Room).Id;
            if(MessageBox.Show(string.Format("Bạn có thật sự muốn chuyển bàn {0} qua bàn {1}", id1, id2), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK) 
            {
                RoomDAO.Instance.SwitchRoom(0, 1);
                loadRoom();
            }
            
            
        }

        #endregion


    }
}
