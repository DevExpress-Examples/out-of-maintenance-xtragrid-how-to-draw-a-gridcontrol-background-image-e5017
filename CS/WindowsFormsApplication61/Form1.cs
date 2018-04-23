using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication61 {
    public partial class Form1 : Form {
        BackgroundImageHelper _biHelper;
        public Form1() {
            InitializeComponent();
            #region DataSourceInitialization
            List<Employee> lst = new List<Employee>();
            for (int i = 0; i < 42; i++) {
                lst.Add(new Employee() { ID = i, FirstName = "Name " + i, BirthDate = DateTime.Now, AtVacation = i % 2 == 0 });
            }
            gridControl1.DataSource = lst; 
            #endregion
            _biHelper = new BackgroundImageHelper(gridView1, (Bitmap)pictureEdit1.Image);
            propertyGrid1.SelectedObject = _biHelper;    
        }

        private void pictureEdit1_Properties_ImageChanged(object sender, EventArgs e) {
            if (pictureEdit1.Image != null) {
                _biHelper.Image = (Bitmap)pictureEdit1.Image;
            }
        }

        private void button1_Click(object sender, EventArgs e) {
        }

        private void Form1_Shown(object sender, EventArgs e) {
            _biHelper.PictureAlignment = ContentAlignment.BottomRight;
        }
    }
    #region TestClass
    public class Employee {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public bool AtVacation { get; set; }
        public DateTime BirthDate { get; set; }
    } 
    #endregion
}
