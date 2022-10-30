using System.Data;

namespace MFCTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ����� ����� �� ������ � ����� ����� �� �� ��������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nameTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (Char.IsDigit(c))
            {
                e.Handled = true;
            }
        }
       
        private void surnameTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (Char.IsDigit(c))
            {
                e.Handled = true;
            }
        }
        private void signUpButton1_Click(object sender, EventArgs e)
        {
            string seriesTrue = seriesTextBox1.Text;
            string numberTrue = numberTextBox2.Text;
            string phoneNumber = phoneNumberTextBox7.Text;
            if (phoneNumber.Length != 11)
            {
                MessageBox.Show("����� ������������ ��� ������ ������. ������ 81112223344");
            }
            else if ((actualAddresstextBox6.Text.Length < 10) 
                || (addressTextBox4.Text.Length < 10) 
                || (placeOfBirthTextBox5.Text.Length < 5))
            {
                MessageBox.Show("����� ������ ���� �� ������ 10 ��������. ����� �������� - �� ������ 5.");
            }
            //TODO: �� �� ��������� ��������� �� ���������� ���� � ����� � ������ 
            
            else if ((seriesTrue.Length != 4) || (numberTrue.Length != 6))
            {
                if ((!Int32.TryParse(seriesTrue, out var valueOne)) || (!Int32.TryParse(numberTrue, out var valueTwo)))
                {
                    MessageBox.Show("�����(������ ������ �����) � �����(����� ����) �������� ������ ���� �������� ��� ����.");
                }
            }
            else if ((surnameTextBox1.Text == "")
                ||(nameTextBox2.Text == "")
                ||(seriesTextBox1.Text =="") //����� ��������
                ||(numberTextBox2.Text =="") // ����� ��������
                ||(issuedByWhomTextBox3.Text == "")
                ||(addressTextBox4.Text == "")
                ||(placeOfBirthTextBox5.Text == "")
                ||(actualAddresstextBox6.Text == "")
                ||(phoneNumberTextBox7.Text == ""))
                //� ���� ��� ������ �� ������ ������������
            {
               
                MessageBox.Show("��������� ��� ����!");
                //TODO:� ������� ���� ��� ��� ���������� ��� �������
            }
            //��� ��� �������� ������ ����� ���� ��������
            else
            {
                int n = tableDataGridView1.Rows.Add();
                tableDataGridView1.Rows[n].Cells[0].Value = surnameTextBox1.Text;
                tableDataGridView1.Rows[n].Cells[1].Value = nameTextBox2.Text;
                tableDataGridView1.Rows[n].Cells[2].Value = middleNameTextBox3.Text;
                tableDataGridView1.Rows[n].Cells[3].Value = birthDayDateTimePicker1.Value;
                tableDataGridView1.Rows[n].Cells[4].Value = actualAddresstextBox6.Text;
                tableDataGridView1.Rows[n].Cells[5].Value = phoneNumberTextBox7.Text;
                //������ �� ������
            }
        }
       

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tableDataGridView1.SelectedRows.Count > 0) //������� ���� �� ���� ������
            {
                int n = tableDataGridView1.SelectedRows[0].Index; 
                tableDataGridView1.Rows.RemoveAt(n);
            }
            else
            {
                MessageBox.Show("������!");
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tableDataGridView1.SelectedRows.Count > 0)
            {
                int n = tableDataGridView1.SelectedRows[0].Index; //������ ��������� ������
                tableDataGridView1.Rows[n].Cells[0].Value = surnameTextBox1.Text;
                tableDataGridView1.Rows[n].Cells[1].Value = nameTextBox2.Text;
                tableDataGridView1.Rows[n].Cells[2].Value = middleNameTextBox3.Text;
                tableDataGridView1.Rows[n].Cells[3].Value = birthDayDateTimePicker1.Value;
                tableDataGridView1.Rows[n].Cells[4].Value = actualAddresstextBox6.Text;
                tableDataGridView1.Rows[n].Cells[5].Value = phoneNumberTextBox7.Text;
            }
            else
            {
                MessageBox.Show("������!�������� ������!");
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tableDataGridView1.SelectedRows.Count > 0)
            {
                tableDataGridView1.Rows.Clear();
            }
            else
            {
                MessageBox.Show("������� ������.", "������");
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog(); // ������� ������ ���������� �����
                sfd.Filter = "XML file (*.xml)|*.xml|All files(*.*)|*.*"; // ������������� ������ ���������� ��������
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    DataSet ds = new DataSet(); // �������  ��� ������
                    DataTable dt = new DataTable(); // ������� ������� ������
                    dt.TableName = "MFC"; 
                    dt.Columns.Add("Surname"); 
                    dt.Columns.Add("Name");
                    dt.Columns.Add("Middle name");
                    dt.Columns.Add("Birthday");
                    dt.Columns.Add("Actual address");
                    dt.Columns.Add("Phone number");
                    ds.Tables.Add(dt); //� ds ��������� �������, � ��������� � ���������, ���������� ����

                    foreach (DataGridViewRow r in tableDataGridView1.Rows) 
                    {
                        DataRow row = ds.Tables["MFC"].NewRow(); // ������� ����� ������ � �������, ���������� � ds
                        row["Surname"] = r.Cells[0].Value;  
                        row["Name"] = r.Cells[1].Value; 
                        row["Middle name"] = r.Cells[2].Value;
                        row["Birthday"] = r.Cells[3].Value;
                        row["Actual address"] = r.Cells[4].Value;
                        row["Phone number"] = r.Cells[5].Value;
                        ds.Tables["MFC"].Rows.Add(row); //���������� ���� ���� ������ � ������� ds.
                    }
                    ds.WriteXml(sfd.FileName);

                    MessageBox.Show("XML ���� ������� ��������.", "���������.", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (tableDataGridView1.Rows.Count > 0) 
                {
                    MessageBox.Show("�������� ���� ����� ��������� ������ �����.", "������.");
                }
                else
                {
                    OpenFileDialog ofd = new OpenFileDialog();
                    ofd.Filter = "XML file (*.xml)|*.xml|All files(*.*)|*.*";
                    if (ofd.ShowDialog() == DialogResult.Cancel)
                        return;

                    DataSet ds = new DataSet(); // ������� ����� ������ ��� ������
                    ds.ReadXml(ofd.FileName); // ���������� � ���� XML-������ �� �����

                    foreach (DataRow item in ds.Tables["MFC"].Rows)
                    {
                        int n = tableDataGridView1.Rows.Add(); // ��������� ����� ����� � dataGridView1
                        tableDataGridView1.Rows[n].Cells[0].Value = item["Surname"];
                        tableDataGridView1.Rows[n].Cells[1].Value = item["Name"];
                        tableDataGridView1.Rows[n].Cells[2].Value = item["Middle name"];
                        tableDataGridView1.Rows[n].Cells[3].Value = item["Birthday"];
                        tableDataGridView1.Rows[n].Cells[4].Value = item["Actual address"];
                        tableDataGridView1.Rows[n].Cells[5].Value = item["Phone number"];
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void nameTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}