using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;
using System.Windows.Forms;

namespace Car_Rental_CO._1
{
    class HelperFunctions
    {
       static int SSN = 0;

        //Checking the validity of the register number (PK) it has to be unique value and consists of 6 digits
        static public bool ValidRegNum(int SentNum, ref bool RegNumExist)
        {
            string ToCount = SentNum.ToString();

            if (ToCount.Length != 6)
                return false;

            string constr = "Data Source=orcl;User ID=scott;Password=tiger;";
            OracleConnection conn = new OracleConnection(constr);
            conn.Open();

            OracleCommand cmd = new OracleCommand();

            cmd.Connection = conn;

            cmd.CommandText = "select registration_number from car where registration_number=:num";
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.Parameters.Add("num", SentNum);

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                dr.Close();
                conn.Close();

                RegNumExist = true;

                return false;
            }

            dr.Close();
            conn.Close();

            RegNumExist = false;

            return true;
        }

        //Parsing address and returning it in the right format

        static public void ParseAddress(string SentAdd, ref string gov, ref string street, ref string blockNo)
        {
            string[] AllAdd = SentAdd.Split(',', '*');

            blockNo = AllAdd[0];
            street = AllAdd[1];
            gov = AllAdd[2];
        }

        static public bool ValidYear(string SentYear)
        {
            int Year = Convert.ToInt32(SentYear);

            if (Year < 1700 || SentYear.Length != 4 || Year > 2018)
                return false;

            return true;
        }

        static public int UserExist(TextBox txtSSN, TextBox txtPassword)
        {
            string constr = "Data Source=orcl;User ID=scott;Password=tiger;";
            OracleConnection conn;
            conn = new OracleConnection(constr);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.Parameters.Add("UserSSN", Convert.ToInt32(txtSSN.Text));
            cmd.Parameters.Add("UserPassword", txtPassword.Text);
            cmd.Parameters.Add("Exist", OracleDbType.Int32).Direction = System.Data.ParameterDirection.Output;

            cmd.CommandText = "UserExists";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.ExecuteNonQuery();

            conn.Close();

            int e = Convert.ToInt32(cmd.Parameters["Exist"].Value.ToString());

            return e;
        }

        static public int MonthYearExist(DateTimePicker dtp)
        {
                     string constr = "Data Source=orcl;User ID=scott;Password=tiger;";
            OracleConnection conn;
            conn = new OracleConnection(constr);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.Parameters.Add("SentMonth", dtp.Value.Month);
            cmd.Parameters.Add("SentYear", dtp.Value.Year);
            cmd.Parameters.Add("Exist", OracleDbType.Int32).Direction = System.Data.ParameterDirection.Output;

            cmd.CommandText = "MonthYearExist";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.ExecuteNonQuery();

            conn.Close();

            int e = Convert.ToInt32(cmd.Parameters["Exist"].Value.ToString());

            return e;
        }

        static public void SetSSN(int sentSSN)
        {
            SSN = sentSSN;
        }

        static public int GetSSN()
        {
           return SSN ;
        }
    }
}