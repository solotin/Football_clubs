using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SR_OBDZ
{
    public partial class Form1 : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter adapter;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
            conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Footballer_DB.accdb");
            conn.Open();
            getClub(playerClub);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqltext;
            switch (comboBox1.SelectedIndex)
            {
                case 0: sqltext = "SELECT Club_name, League, Stadium FROM Club;"; break;
                case 1: sqltext = "SELECT Footballer.[First Name], Footballer.[Last Name], Footballer.Ages, Footballer.Nationality, Club.Club_name, Footballer.Role FROM Footballer,Club WHERE Footballer.Club_ID=Club.Club_ID ORDER BY Footballer.[First Name], Footballer.[Last Name], Footballer.Ages;"; break;
                case 2: sqltext = "SELECT Footballer.[First Name], Footballer.[Last Name], Effectiveness.Goals_num, Effectiveness.Passes_num FROM Footballer, Effectiveness WHERE Footballer.Footballer_ID=Effectiveness.Footballer_ID ORDER BY Effectiveness.Goals_num DESC, Effectiveness.Passes_num DESC;"; break;
                case 3: sqltext = "SELECT Footballer.[First Name], Footballer.[Last Name], Sallary.Sallary FROM Footballer, Sallary WHERE Footballer.Footballer_ID=Sallary.Footballer_ID ORDER BY Sallary.Sallary DESC;"; break;
                case 4: sqltext = "SELECT * FROM League;"; break;
                case 5: sqltext = "SELECT * FROM Stadium ORDER BY Capacity DESC;"; break;
                default: return;
            }
            OleDbCommand command = new OleDbCommand(sqltext, conn);
            adapter = new OleDbDataAdapter(command);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void getClub(ComboBox cb)
        {
            OleDbDataReader reader = (new OleDbCommand("SELECT Club_name FROM Club;", conn)).ExecuteReader();
            if (reader.HasRows)
                while (reader.Read())
                    cb.Items.Add(reader.GetValue(0));
            cb.SelectedIndex = 0;
            reader.Close();
        }
        private void getLeagues(ComboBox cb)
        {
            OleDbDataReader reader = (new OleDbCommand("SELECT League FROM League;", conn)).ExecuteReader();
            if (reader.HasRows)
                while (reader.Read())
                    cb.Items.Add(reader.GetValue(0));
            cb.SelectedIndex = 0;
            reader.Close();
        }
        private void getStaduium(ComboBox cb)
        {
            OleDbDataReader reader = (new OleDbCommand("SELECT Stadium_name FROM Stadium;", conn)).ExecuteReader();
            if (reader.HasRows)
                while (reader.Read())
                    cb.Items.Add(reader.GetValue(0));
            cb.SelectedIndex = 0;
            reader.Close();
        }
        private void getFootballers(ComboBox cb)
        {
            OleDbDataReader reader = (new OleDbCommand("SELECT [First Name] + ' ' + [Last Name] FROM Footballer;", conn)).ExecuteReader();
            if (reader.HasRows)
                while (reader.Read())
                    cb.Items.Add(reader.GetValue(0));
            cb.SelectedIndex = 0;
            reader.Close();
        }
        private void getNational(ComboBox cb)
        {
            OleDbDataReader reader = (new OleDbCommand("SELECT DISTINCT Nationality FROM Footballer;", conn)).ExecuteReader();
            if (reader.HasRows)
                while (reader.Read())
                    cb.Items.Add(reader.GetValue(0));
            cb.SelectedIndex = 0;
            reader.Close();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }

        private void clubAdd_Click(object sender, EventArgs e)
        {
            OleDbCommand comand = new OleDbCommand(String.Format("INSERT INTO Club(Club_name, League, Stadium) VALUES('{0}','{1}','{2}')",clubName.Text,clubLg.SelectedItem,clubStad.SelectedItem), conn);
            comand.ExecuteNonQuery();
            MessageBox.Show("Запись добавлена!","Успешно",MessageBoxButtons.OK);
        }

        private void stadAdd_Click(object sender, EventArgs e)
        {
            OleDbCommand comand = new OleDbCommand(String.Format("INSERT INTO Stadium(Stadium_name, Address, Capacity) VALUES('{0}','{1}',{2})",stadName.Text,stadAdr.Text,stadCap.Value), conn);
            comand.ExecuteNonQuery();
            MessageBox.Show("Запись добавлена!", "Успешно", MessageBoxButtons.OK);
        }

        private void playerAdd_Click(object sender, EventArgs e)
        {
            OleDbCommand comand = new OleDbCommand(String.Format("INSERT INTO Footballer([First Name], [Last Name], Ages, Nationality, Club_ID, Role) SELECT '{0}','{1}',{2},'{3}', Club.Club_ID,'{5}' FROM Club WHERE Club_name='{4}'", playerFN.Text,playerLN.Text,playerAge.Value,playerNat.Text,playerClub.SelectedItem, playerRole.SelectedItem), conn);
            comand.ExecuteNonQuery();
            MessageBox.Show("Запись добавлена!", "Успешно", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbCommandBuilder combuild = new OleDbCommandBuilder(adapter);
            adapter.Update(ds);
        }

        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            if ((changeSallPlayer.Items).Count == 0) getFootballers((ComboBox)sender);
        }

        private void changeSallSave_Click(object sender, EventArgs e)
        {
            OleDbCommand comand = new OleDbCommand(String.Format("UPDATE Sallary SET Sallary.Sallary={0} WHERE Sallary.Footballer_ID=(SELECT Footballer_ID FROM Footballer WHERE [First Name]+' '+[Last Name]='{1}')", changeSallSall.Value, changeSallPlayer.SelectedItem), conn);
            comand.ExecuteNonQuery();
            MessageBox.Show("Запись обновлена!", "Успешно", MessageBoxButtons.OK);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OleDbCommand comand = new OleDbCommand(String.Format("UPDATE Effectiveness SET Goals_num={0}, Passes_num={1} WHERE Footballer_ID=(SELECT Footballer_ID FROM Footballer WHERE [First Name]+' '+[Last Name]='{2}')", changeResGoal.Value, changeResAs.Value, changeResPlayer.SelectedItem), conn);
            comand.ExecuteNonQuery();
            MessageBox.Show("Запись обновлена!", "Успешно", MessageBoxButtons.OK);
        }

        private void filterName_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterValue.Items.Clear();
            filterValue.Text = "";
            switch (filterName.SelectedIndex)
            {
                case 1: getClub(filterValue); break;
                case 2: getLeagues(filterValue); break;
                case 3: getNational(filterValue); break;   
            }
        }

        private void clubLg_DropDown(object sender, EventArgs e)
        {
            if (clubLg.Items.Count == 0) getLeagues(clubLg);
        }

        private void clubStad_DropDown(object sender, EventArgs e)
        {
            if(clubStad.Items.Count==0) getStaduium(clubStad);
        }

        private void filterGet_Click(object sender, EventArgs e)
        {
            string sqltext;
            switch (filterName.SelectedIndex)
            {
                default: sqltext = "SELECT Footballer.[First Name], Footballer.[Last Name], Sallary.Sallary FROM Footballer, Sallary ORDER BY(Sallary.Sallary) DESC;"; break;
                case 1: sqltext = String.Format("SELECT Club.Club_name, Footballer.[First Name], Footballer.[Last Name], Sallary.Sallary FROM(Club INNER JOIN Footballer ON Club.Club_ID = Footballer.Club_ID) INNER JOIN Sallary ON Footballer.Footballer_ID = Sallary.Footballer_ID WHERE Club.Club_name = '{0}' ORDER BY Sallary.Sallary DESC;",filterValue.SelectedItem); break;
                case 2: sqltext = String.Format("SELECT League.League, Footballer.[First Name], Footballer.[Last Name], Sallary.Sallary FROM League INNER JOIN((Club INNER JOIN Footballer ON Club.Club_ID = Footballer.Club_ID) INNER JOIN Sallary ON Footballer.Footballer_ID = Sallary.Footballer_ID) ON League.League = Club.League WHERE League.League = '{0}' ORDER BY Sallary.Sallary DESC;", filterValue.SelectedItem); break;
                case 3: sqltext = String.Format("SELECT Footballer.Nationality, Footballer.[First Name], Footballer.[Last Name], Sallary.Sallary FROM Footballer INNER JOIN Sallary ON Footballer.Footballer_ID = Sallary.Footballer_ID WHERE Footballer.Nationality='{0}' ORDER BY Sallary.Sallary DESC;", filterValue.SelectedItem); break;
            }
            OleDbCommand command = new OleDbCommand(sqltext, conn);
            adapter = new OleDbDataAdapter(command);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void salSumGet_Click(object sender, EventArgs e)
        {
            string sqltext;
            switch (salSumFilter.SelectedIndex)
            {
                default: sqltext = "SELECT Club.Club_name, SUM(Sallary.Sallary) AS Sallary_SUM FROM(Club INNER JOIN Footballer ON Club.Club_ID = Footballer.Club_ID) INNER JOIN Sallary ON Footballer.Footballer_ID = Sallary.Footballer_ID GROUP BY(Club.Club_name) ORDER BY SUM(Sallary.Sallary) DESC;"; break;
                case 1: sqltext = "SELECT League.League, Sum(Sallary.Sallary) AS Sallary_SUM FROM League INNER JOIN((Club INNER JOIN Footballer ON Club.Club_ID = Footballer.Club_ID) INNER JOIN Sallary ON Footballer.Footballer_ID = Sallary.Footballer_ID) ON League.League = Club.League GROUP BY(League.League) ORDER BY SUM(Sallary.Sallary) DESC;"; break;
            }
            OleDbCommand command = new OleDbCommand(sqltext, conn);
            adapter = new OleDbDataAdapter(command);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void profitPlayerGet_Click(object sender, EventArgs e)
        {
            OleDbCommand command = new OleDbCommand(String.Format("SELECT Footballer.Role, Footballer.[First Name], Footballer.[Last Name], IIF(Effectiveness.Goals_num+Effectiveness.Passes_num>0, INT(Sallary.Sallary/(Effectiveness.Goals_num+Effectiveness.Passes_num)),0) AS Most_profit_payer FROM (Footballer INNER JOIN Sallary ON Footballer.Footballer_ID = Sallary.Footballer_ID) INNER JOIN Effectiveness ON Footballer.Footballer_ID = Effectiveness.Footballer_ID WHERE Footballer.Role='{0}' ORDER BY 4 DESC",profitPlayer.SelectedItem), conn);
            adapter = new OleDbDataAdapter(command);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void mostPopularGet_Click(object sender, EventArgs e)
        {
            string sqltext;
            if (mostPopular.SelectedIndex == 0)
                sqltext = "SELECT Stadium.Stadium_name, COUNT(Club.Club_name) AS [Кол-во клубов] FROM Stadium INNER JOIN Club ON Stadium.Stadium_name = Club.Stadium GROUP BY Stadium.Stadium_name ORDER BY 2 DESC, 1;";
            else
                sqltext = "SELECT Nationality, COUNT(Footballer_ID) AS [Кол-во футболистов] FROM Footballer GROUP BY Nationality ORDER BY 2 DESC , 1;";
            OleDbCommand command = new OleDbCommand(sqltext, conn);
            adapter = new OleDbDataAdapter(command);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
