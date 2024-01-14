using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity;
using Grad_Tax.DB;


namespace Grad_Tax.Pages
{
    public partial class Page_Users : DevExpress.XtraEditors.XtraUserControl
    {
         All_Tabls allTabls = new All_Tabls();
           // private DB_GradEntities db = new DB_GradEntities();
           // private Users tbUsers = new Users();

         
            public Page_Users()
            {
                InitializeComponent();
                LoadData();
                
            }

            public void LoadData()
            {
                Grad_Tax.DB.DB_GradEntities dbContext = new Grad_Tax.DB.DB_GradEntities();
                dbContext.Users.LoadAsync()
                    .ContinueWith(loadTask => { gridControl1.DataSource = dbContext.Users.Local.ToBindingList(); },
                        System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
            }

            private void Add()
            {
                if (txt_name.Text == "" || txt_password.Text == "" || txt_premish.Text == "")
                {

                    XtraMessageBox.Show("الحقل مطلوب ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    AddData();
                    LoadData();
                }
            }

            // دالة اضافة
            private void AddData()
        {
            var db = allTabls.db;
            var tbUsers = allTabls.tbUsers;

            tbUsers.Name = txt_name.Text;
            tbUsers.Password = txt_password.Text;
            tbUsers.PermissionType = txt_premish.Text;

            db.Entry(tbUsers).State = EntityState.Added;

            db.SaveChanges();
            XtraMessageBox.Show("تمت الاضافة بنجاح", "اضافة");
            
        }

        private void btn_Add_Click(object sender, EventArgs e)
            {
               Add();
            }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_name.Text = txt_password.Text = txt_premish.Text = null;

        }

        private void btn_edt_Click(object sender, EventArgs e)
        {
            int ID;
            var db = allTabls.db;
            var tbUsers = allTabls.tbUsers;
            try
            {
                ID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID_User"));
                if (ID > 0)
                {

                    tbUsers = db.Users.Where(x => x.ID_User == ID).FirstOrDefault();
                    tbUsers.ID_User = ID;

                    tbUsers.Name = txt_name.Text;
                    tbUsers.Password = txt_password.Text;
                    tbUsers.PermissionType = txt_premish.Text;


                    db.Entry(tbUsers).State = EntityState.Modified;
                    db.SaveChanges();
                    XtraMessageBox.Show("تم تعديل البيانات بالنجاح", "عملية تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();

                }
                else
                {
                    XtraMessageBox.Show("لا يوجد بيانات لتعديلها");
                }
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int id;
            var db = allTabls.db;
            var tbUsers = allTabls.tbUsers;
            var rs = XtraMessageBox.Show("هل انت متأكد من هذا الاجراء , لايمكن استرجاع البيانات", "اجراء حدف",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
                try
                {
                    id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID_User"));
                    if (id > 0)
                    {
                        tbUsers = db.Users.Where(x => x.ID_User == id).FirstOrDefault();

                        db.Entry(tbUsers).State = EntityState.Deleted;
                        db.SaveChanges();

                        LoadData();
                    }
                    else
                    {
                        XtraMessageBox.Show("لا يوجد بيانات لحدفها");
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
        }
    }


    
}
    