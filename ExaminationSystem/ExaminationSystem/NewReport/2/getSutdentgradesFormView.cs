using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystem.NewReport._2
{
    public partial class getSutdentgradesFormView : Form
    {
        public int studId { get; set;}
        public getSutdentgradesFormView(string id)
        {
            InitializeComponent();
            studId = int.Parse(id);



        }

        private void getSutdentgradesFormView_Load(object sender, EventArgs e)
        {

        }
    }
}
