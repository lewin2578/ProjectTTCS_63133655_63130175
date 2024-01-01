using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace ProjectTTCS_63133655_63130175
{
    public partial class simForm : Form
    {
        // MÔ PHỎNG CÁC CHIẾN LƯỢC ĐIỀU PHỐI TIẾN TRÌNH
        // NTU
        // Nguyễn Hoài Huy Đạt 63133655
        // Đinh Bá Đạt 63130175
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

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // Structs and global variables
        public struct process // tiến trình
        {
            public string name; // tên tiến trình
            public int timeQUEUE, timeCPU, priority; // tgian đến, tgian xử lý, độ ưu tiên
            public int timeIN, timeOUT, timeWAIT, timeSAVE; // tgian vào, tgian ra, tgian chờ, tgian lưu lại trong hệ thống
            public int index;
        }

        public struct color // màu vẽ cho gantt chart
        {
            public int x, y, z; // RGB 
        }

        public int n, m; // số tiến trình
        public int q; // giá trị quantum
        public int select; // biến chọn chiến lược

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // Controls
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

        private void btnRun_Click(object sender, EventArgs e)
        {
            process[] p = new process[100];

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
                    p[row + 1].index = row + 1;
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
                    case 1: FCFS(p);break;//FCFS
                    case 2: SJF(p);break;//SJF độc quyền
                    case 3: SRTF(p);break;//SJF ko độc quyền
                    case 4: RR(p);break;//RR
                    case 5:PRIORITY_nonpreemp(p);break;//Prior độc quyền
                    case 6: PRIORITY_preemp(p); break;//Prior ko độc quyền
                }
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // Functions
        public void swap(process[] p, int i, int j)
        {
            p[0] = p[i];
            p[i] = p[j];
            p[j] = p[0];
        }

        public void sort(process[] p) // sắp xếp theo tgian đến
        {
            for(int i=1; i<=n; i++)
                for(int j = i+1; j<=n; j++)
                    if (p[i].timeQUEUE > p[j].timeQUEUE)
                        swap(p, i, j);
        }

        public void cpu_sort(process[] p) // sắp xếp tgian cpu (chỉ dành cho SJF)
        {
            sort(p);
            for (int i = 1; i <= n; i++)
                for (int j = i + 1; j <= n; j++)
                    if (p[i].timeQUEUE == p[j].timeQUEUE && p[i].timeCPU > p[j].timeCPU)
                        swap(p, i, j);
        }

        public void gantt(process[] p) // biểu đồ Gantt
        {
            Graphics g = pnlGantt.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            Font font = new Font("Microsoft Sans Serif", 8f, FontStyle.Regular);

            color[] c = new color[1000];
            Random r = new Random();
            
            for (int i = 1; i <= n; i++)
            {
                c[i].x = r.Next(100, 255);
                c[i].y = r.Next(100, 255);
                c[i].z = r.Next(100, 255);
            }

            int a = 0;
            for (int i = 1; i <= m; i++)
            {
                if (i == 1)
                    a = p[i].timeIN * 15 + 1;
                else
                    a += 15 * ((p[i - 1].timeOUT + 1) - p[i - 1].timeIN) + 1;
                System.Windows.Forms.TextBox txb = new System.Windows.Forms.TextBox();
                txb.Location = new Point(a, 1);
                txb.Multiline = true;
                txb.Font = font;
                txb.Text = " " + p[i].name;
                txb.Text += "\r\n";
                txb.Text += "\r\n " + p[i].timeIN;
                txb.BorderStyle = 0;
                txb.BackColor = System.Drawing.Color.FromArgb(255, c[p[i].index].x, c[p[i].index].y, c[p[i].index].z);
                txb.AutoSize = false;
                txb.ReadOnly = true;
                txb.Margin = new Padding(0, 0, 0, 0);
                txb.Size = new Size(15 * ((p[i].timeOUT + 1) - p[i].timeIN), 56);
                pnlGantt.Controls.Add(txb);
            }
        }

        public double avgwait(process[] p) // trung bình tgian đợi
        {
            double t = 0;
            for (int i = 1; i <= n; i++)
                t += p[i].timeWAIT;
            return t / n;
        }

        public double avgsave(process[] p) // trung bình tgian lưu lại trong máy
        {
            double t = 0;
            for (int i = 1; i <= n; i++)
                t += p[i].timeSAVE;
            return t / n;
        }
        public void output(process[] p)
        {
            gantt(p);
            lblEnd.Text += " " + p[m].timeOUT.ToString();
            //thứ tự ban đầu
            for (int i = 1; i <= n; i++)
                for (int j = i + 1; j <= n; j++)
                    if (p[i].index > p[j].index)
                        swap(p, i, j);
            //for SJF, RR, Prior
            for (int i = 1; i <= n; i++)
                for (int j = i + 1; j <= n; j++)
                    if (p[i].index == p[j].index && p[i].timeOUT < p[j].timeOUT)
                        swap(p, i, j);
            //for RR
            for (int i = 1; i <= n; i++)
                for (int j = i + 1; j <= m; j++)
                    if (p[j].index == i && p[j].timeSAVE != 0)
                        swap(p, i, j);
            Console.WriteLine($"Thời gian đợi trung bình: {avgwait(p)}");
            Console.WriteLine($"Thời gian lưu lại trung bình: {avgsave(p)}");
            Console.WriteLine("Tiến trình\t\tTG đợi\t\tTG lưu lại\n");
            for (int i = 1; i <= n; i++)
                Console.WriteLine($"{p[i].name}\t\t{p[i].timeWAIT}\t\t{p[i].timeSAVE}");
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // Algorithms
        public void FCFS(process[] p) // First Come First Served
        {
            sort(p);
            p[1].timeIN = p[1].timeQUEUE;
            p[1].timeOUT = p[1].timeQUEUE + p[1].timeCPU;
            p[1].timeSAVE = p[1].timeOUT - p[1].timeQUEUE;
            p[1].timeWAIT = p[1].timeSAVE - p[1].timeCPU;
            int timeOUT = p[1].timeOUT;
            for (int i = 2; i <= n; i++)
            { 
                timeOUT += p[i].timeCPU;
                p[i].timeIN = p[i - 1].timeOUT;
                p[i].timeOUT = timeOUT;
                p[i].timeSAVE = p[i].timeOUT - p[i].timeQUEUE;
                p[i].timeWAIT = p[i].timeSAVE - p[i].timeCPU;
            }
            m = n;
            output(p);
        }

        void SJF(process[] p) // Shortest Job First (SJF non preemp - độc quyền)
        {
            cpu_sort(p);
            int temp, min = -1;
            p[1].timeIN = p[1].timeQUEUE;
            p[1].timeOUT = p[1].timeQUEUE + p[1].timeCPU;
            p[1].timeSAVE = p[1].timeOUT - p[1].timeQUEUE;
            p[1].timeWAIT = p[1].timeSAVE - p[1].timeCPU;
            for (int i = 2; i <= n; i++)
            {
                temp = p[i - 1].timeOUT;
                int low = p[i].timeCPU;
                for (int j = i; j <= n; j++)
                {
                    if (temp >= p[j].timeQUEUE && low >= p[j].timeCPU)
                    {
                        low = p[j].timeCPU;
                        min = j;
                    }
                }
                p[min].timeOUT = temp + p[min].timeCPU;
                p[min].timeSAVE = p[min].timeOUT - p[min].timeQUEUE;
                p[min].timeWAIT = p[min].timeSAVE - p[min].timeCPU;
                swap(p, min, i);
            }
            for (int i = 2; i <= n; i++)
                p[i].timeIN = p[i - 1].timeOUT;
            m = n;
            output(p);
        }

        public void SRTF(process[] p) // Shortest Remaining Time First (SJF preemp - ko độc quyền)
        {
            int timeOUT = 0;
	        for(int i = 1; i <= n; i++) 
	        {
                if (timeOUT < p[i].timeQUEUE)
                    timeOUT = p[i].timeQUEUE + p[i].timeCPU;
                else
                    timeOUT += p[i].timeCPU;
            }
	        process[] p1 = new process[100];
	        for(int i = 1; i <= n; i++)
		        p1[i]=p[i];
            int j = 1; 
	        m = 1;
            int temptime = 0;
            for (int t = 0; t <= timeOUT; t++) 
            {
                if (m > 1 && j < m) 
                {
                    if (temptime < p[j].timeCPU)
                        temptime++;
                    if (temptime == p[j].timeCPU) 
                    { 
                        p1[p[j].index].timeOUT = t;
                        p1[p[j].index].timeSAVE = p1[p[j].index].timeOUT - p1[p[j].index].timeQUEUE;
                        p1[p[j].index].timeWAIT = p1[p[j].index].timeSAVE - p1[p[j].index].timeCPU;

                        p[j].timeIN = t - p[j].timeCPU;
                        p[j].timeOUT = p1[p[j].index].timeOUT;
                        p[j].timeSAVE = p1[p[j].index].timeSAVE;
                        p[j].timeWAIT = p1[p[j].index].timeWAIT;
                  
                        temptime = 0;
                        j++;
                    }
                }
                for (int i = 1; i <= n; i++)
                    if (t == p1[i].timeQUEUE) 
			        {
                        m++;
                        int k = m - 1;
                        if (temptime > 0 && p1[i].timeCPU < p[j].timeCPU - temptime) 
                        {
                            m++;
                            k = m - 1;
                            for (k = m - 1; k > j + 1; k--)
                                p[k] = p[k - 2];
                            p[j + 1] = p1[i];
 
                            p[j + 2] = p[j];
                            p[j + 2].timeCPU -= temptime;
 
                            p[j].timeIN = t - temptime;
                            p[j].timeOUT = t;
                            p[j].timeCPU = temptime;
                            temptime = 0;
                            j++;
                        } 
                        else 
                        {
                            while (k > j + 1 && p1[i].timeCPU < p[k - 1].timeCPU) 
                            {
                                p[k] = p[k - 1];
                                k--;
                                if (k == j + 1 && p1[i].timeCPU < p[k - 1].timeCPU - temptime) 
                                {
                                    p[k] = p[k - 1];
                                    k--;
                                }
                            }
                            p[k] = p1[i];
                        }
                    }
            }
            m--;
            output(p);
        }

        public void RR(process[] p) // Round Robin
        {
            int timeOUT = 0;
            for (int i = 1; i <= n; i++)
            {
                if (timeOUT < p[i].timeQUEUE)
                    timeOUT = p[i].timeQUEUE + p[i].timeCPU;
                else
                    timeOUT += p[i].timeCPU;
            }
            process[] p1 = new process[100];
            for (int i = 1; i <= n; i++)
                p1[i] = p[i];
            m = 1;
            int count = 0;
            int j = 1;
            int temptime = 0;
            for (int t = 0; t <= timeOUT; t++) 
            {
                if (m > 1 && j<m) 
                {
                    count++;
                    if (count <= q && p[j].timeCPU - temptime > 0)
                        temptime++;
                    if (count == q && p[j].timeCPU - temptime > 0) 
                    {
                        m++;
                        p[m - 1] = p[j];
                        p[m - 1].timeCPU -= temptime;
                    }
                    if (p[j].timeCPU - temptime == 0) 
                    {
                        p1[p[j].index].timeOUT = t;
                        p1[p[j].index].timeSAVE = p1[p[j].index].timeOUT - p1[p[j].index].timeQUEUE;
                        p1[p[j].index].timeWAIT = p1[p[j].index].timeSAVE - p1[p[j].index].timeCPU;
                
                        p[j].timeOUT = p1[p[j].index].timeOUT;
                        p[j].timeSAVE = p1[p[j].index].timeSAVE;
                        p[j].timeWAIT = p1[p[j].index].timeWAIT;
                    }
                    if (count == q || p[j].timeCPU - temptime == 0)
                    {
                        p[j].timeOUT = t;
                        p[j].timeCPU = temptime;
                        p[j].timeIN = t - p[j].timeCPU;
                        j++;
                        temptime = 0;
                        count = 0;
                    }
                }
                for (int i = 1; i <= n; i++)
                    if (t == p1[i].timeQUEUE)
                    {
                        m++;
                        p[m - 1] = p1[i];
                    }
            }
            m--;
            output(p);
        }

        public void PRIORITY_nonpreemp(process[] p) // Priority độc quyền
        {
            int timeOUT = 0;
            for (int i = 1; i <= n; i++)
            {
                if (timeOUT < p[i].timeQUEUE)
                    timeOUT = p[i].timeQUEUE + p[i].timeCPU;
                else
                    timeOUT += p[i].timeCPU;
            }
            process[] p1 = new process[100];
            for (int i = 1; i <= n; i++)
                p1[i] = p[i];
            int j = 1;
            m = 1;
            int temptime = 0;
            for (int t = 0; t <= timeOUT; t++)
            {
                if (m > 1 && j < m)
                {
                    if (temptime < p[j].timeCPU) temptime++;
                    if (temptime == p[j].timeCPU)
                    {
                        p[j].timeIN = t - p[j].timeCPU;
                        p[j].timeOUT = p[j].timeIN + p[j].timeCPU;
                        p[j].timeSAVE = p[j].timeOUT - p[j].timeQUEUE;
                        p[j].timeWAIT = p[j].timeSAVE - p[j].timeCPU;
                        temptime = 0;
                        j++;
                    }
                }
                for (int i = 1; i <= n; i++)
                    if (t == p1[i].timeQUEUE)
                    {
                        int k = m;
                        while (k > j + 1 && p1[i].priority < p[k - 1].priority)
                        {
                            p[k] = p[k - 1];
                            k--;
                        }
                        p[k] = p1[i];
                        m++;
                    }
            }
            m--;
            output(p);
        }

        public void PRIORITY_preemp(process[] p) // Priority ko độc quyền
        {
            int timeOUT = 0;
            for (int i = 1; i <= n; i++)
            {
                if (timeOUT < p[i].timeQUEUE)
                    timeOUT = p[i].timeQUEUE + p[i].timeCPU;
                else
                    timeOUT += p[i].timeCPU;
            }
            process[] p1 = new process[100];
            for (int i = 1; i <= n; i++)
                p1[i] = p[i];
            int j = 1;
            m = 1;
            int temptime = 0;
            for (int t = 0; t <= timeOUT; t++)
            {
                if (m > 1 && j < m)
                {
                    if (temptime < p[j].timeCPU)
                        temptime++;
                    if (temptime == p[j].timeCPU)
                    {
                        p1[p[j].index].timeOUT = t;
                        p1[p[j].index].timeSAVE = p1[p[j].index].timeOUT - p1[p[j].index].timeQUEUE;
                        p1[p[j].index].timeWAIT = p1[p[j].index].timeSAVE - p1[p[j].index].timeCPU;

                        p[j].timeIN = t - p[j].timeCPU;
                        p[j].timeOUT = p1[p[j].index].timeOUT;
                        p[j].timeSAVE = p1[p[j].index].timeSAVE;
                        p[j].timeWAIT = p1[p[j].index].timeWAIT;

                        temptime = 0;
                        j++;
                    }
                }
                for (int i = 1; i <= n; i++)
                    if (t == p1[i].timeQUEUE)
                    {
                        m++;
                        int k = m - 1;
                        if (temptime > 0 && p1[i].priority < p[j].priority)
                        {
                            m++;
                            k = m - 1;
                            for (k = m - 1; k > j + 1; k--)
                                p[k] = p[k - 2];
                            p[j + 1] = p1[i];
                            p[j + 2] = p[j];
                            p[j + 2].timeCPU -= temptime;
                            p[j].timeIN = t - temptime;
                            p[j].timeOUT = t;
                            p[j].timeCPU = temptime;
                            temptime = 0;
                            j++;
                        }
                        else
                        {
                            while (k > j && p1[i].priority < p[k - 1].priority)
                            {
                                p[k] = p[k - 1];
                                k--;
                            }
                            p[k] = p1[i];
                        }
                    }
            }
            m--;
            output(p);
        }
    }
}
