using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTTCS_63133655_63130175
{
    public partial class simForm : Form
    {
        public simForm()
        {
            InitializeComponent();
        }

        private void simForm_Load(object sender, EventArgs e)
        {
            TextBoxWriter writer = new TextBoxWriter(txtOutput);
            Console.SetOut(writer);
            pnlGantt.Controls.Clear();
            pnlGantt.Refresh();
            txtOutput.Clear();
            txtOutput.Refresh();
        }
        //Input
        public struct proccess
        {
            public string name;
            public int timeQUEUE, timeCPU, priority;
            public int timeIN, timeOUT, timeWAIT, timeSAVE;
        }

        public int n, m;
        public int q;
        public int select;
        //Control
        private void chooseStrip_Click(object sender, EventArgs e)
        {
            lblSign.Visible = false;
        }

        private void FCFS_Choose(object sender, EventArgs e)
        {
            lblChoose.Text = "First Come First Served";
            pnlPreemp.Visible = false;
            pnlQuantum.Visible = false;
            dataGridInput.Columns["gridPrior"].Visible = false;
        }

        private void SJF_Choose(object sender, EventArgs e)
        {
            lblChoose.Text = "Shortest Job First";
            pnlPreemp.Visible = true;
            pnlQuantum.Visible = false;
            dataGridInput.Columns["gridPrior"].Visible = false;
        }

        private void RR_Choose(object sender, EventArgs e)
        {
            lblChoose.Text = "Round Robin";
            pnlPreemp.Visible = false;
            pnlQuantum.Visible = true;
            dataGridInput.Columns["gridPrior"].Visible = false;
        }

        private void Prior_Choose(object sender, EventArgs e)
        {
            lblChoose.Text = "Priority";
            pnlPreemp.Visible = true;
            pnlQuantum.Visible = false;
            dataGridInput.Columns["gridPrior"].Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            simForm_Load(sender, e);
            pnlGantt.Controls.Clear();
            pnlGantt.Refresh();
            txtOutput.Clear();
            txtOutput.Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Refresh();

            dataGridInput.AutoGenerateColumns = false;
            dataGridInput.AllowUserToAddRows = false;
            dataGridInput.Columns[1].ReadOnly = false;
            dataGridInput.Rows.Insert(dataGridInput.Rows.Count, new object[] { "P" + (dataGridInput.Rows.Count + 1), dataGridInput.Rows.Count, dataGridInput.Rows.Count + 1, dataGridInput.Rows.Count + 1 });
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            pnlGantt.Refresh();
            dataGridInput.AllowUserToAddRows = false;
            dataGridInput.Rows.RemoveAt(dataGridInput.Rows.Count - 1);
        }

        private void pnlQuantum_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            proccess[] p = new proccess[100];

            this.Refresh();
            txtOutput.Clear();
            txtOutput.Refresh();
            pnlGantt.Controls.Clear();

            if (dataGridInput.RowCount <= 1)
            {
                MessageBox.Show("Vui lòng nhập dữ liệu trước khi chạy!!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);
                return;
            }
            else
            {
                if (lblChoose.Text == "Round Robin" && quantumInput.Value <= 0)
                {
                    MessageBox.Show("Giá trị của quantum phải lơn hơn 0!!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);
                    return;
                }
                else
                    q = int.Parse(quantumInput.Value.ToString());
                n = dataGridInput.Rows.Count;
                for (int row = 0; row < dataGridInput.Rows.Count; row++)
                {
                    for (int col = 0; col < dataGridInput.Rows[row].Cells.Count; col++)
                    {
                        if (col == 0)
                            p[row+1].name = dataGridInput.Rows[row].Cells[col].Value.ToString();
                        if (col == 1)
                            p[row+1].timeQUEUE = int.Parse(dataGridInput.Rows[row].Cells[col].Value.ToString());
                        if (col == 2)
                            p[row+1].timeCPU = int.Parse(dataGridInput.Rows[row].Cells[col].Value.ToString());
                        if (col == 3)
                            p[row+1].priority = int.Parse(dataGridInput.Rows[row].Cells[col].Value.ToString());
                    }
                }
                if (lblChoose.Text == "First Come First Served")
                    select = 1;
                if (lblChoose.Text == "Shortest Job First")
                {
                    if (radioNonPreemp.Checked)
                        select = 2;
                    else
                        select = 3;
                }
                if (lblChoose.Text == "Round Robin")
                    select = 4;
                if (lblChoose.Text == "Priority")
                {
                    if (radioNonPreemp.Checked)
                        select = 5;
                    else
                        select = 6;
                }

                switch(select)
                {
                    case 1:;break;//FCFS
                    case 2:;break;//SJF doc quyen
                    case 3:;break;//SJF ko doc quyen
                    case 4:;break;//RR
                    case 5:;break;//Prior doc quyen
                    case 6:;break;//Prior ko doc quyen
                }
            }
            //for testing
            Console.WriteLine($"{n}\t{select}\t{q}");
            Console.WriteLine("Name\tQUEUE\tCPU\tPriority\n");
            for (int i = 1; i <= n; i++)
                Console.WriteLine($"{p[i].name}\t{p[i].timeQUEUE}\t{p[i].timeCPU}\t{p[i].priority}");
        }
    }
}
