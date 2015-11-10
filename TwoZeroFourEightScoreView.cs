using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace twozerofoureight
{
    public partial class TwoZeroFourEightScoreView : Form, View
    {
        Model model;       
       //TwoZeroFourEightScoreView s = new TwoZeroFourEightScoreView();

        public TwoZeroFourEightScoreView()
        {
            InitializeComponent();
            model = new TwoZeroFourEightModel();
           
           
        }

        public void Notify(Model m)
        {
            UpdateScore(((TwoZeroFourEightModel)m).Score());
        }

        

        private void UpdateScore(int sum)
        {
            lblScore.Text = Convert.ToString(sum);
        }

        


    }
}
