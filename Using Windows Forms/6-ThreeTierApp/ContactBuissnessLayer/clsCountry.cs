using ContactDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBuissnessLayer
{
    public class clsCountry
    { 
        enum enMode { AddNew, Update}
        enMode Mode = enMode.AddNew;

        #region Properties
        public int CountryID { get; private set; }
        public string CountryName { get;  set; }
        public string Code { get; set; }
        public string PhoneCode { get; set; }

        #endregion


        #region Constructors
        public clsCountry()
        {
            CountryID = -1;
            CountryName = string.Empty;
            Code = string.Empty;
            PhoneCode = string.Empty;
            Mode = enMode.AddNew;
        }

        private clsCountry(int CountryID, string CountryName, string Code , string PhoneCode)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
            this.Code = Code;
            this.PhoneCode = PhoneCode;
            Mode = enMode.Update;
        } 
        #endregion

        public static clsCountry Find(int CountryID)
        {
            string countryName = "", code = "", phoneCode = "";
           if(clsCountryDataAccess.GetCountryInfoByID(CountryID,ref countryName, ref code, ref phoneCode))
            {
                return new clsCountry(CountryID,countryName, code, phoneCode);
            }

            return null;
        }
        public static clsCountry Find(string CountryName)
        {
            int CountryID = -1;
            string code = "", phoneCode = "";
            if (clsCountryDataAccess.GetCountryInfoByName(ref CountryID, ref CountryName, ref code, ref phoneCode))
            {
                return new clsCountry(CountryID, CountryName, code, phoneCode);
            }

            return null;
        }
        private bool _AddNewCountry()
        {
            this.CountryID = clsCountryDataAccess.AddNewCountry(this.CountryName, this.Code, this.PhoneCode);
            return CountryID!=-1;
        }

        private bool _UpdateCountry()
        {
            return clsCountryDataAccess.UpdateCountry(this.CountryID, this.CountryName,this.Code, this.PhoneCode);
        }


        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if(_AddNewCountry())
                    {
                        Mode = enMode.Update;
                        return true;
                    }else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateCountry();
            }
            return false;
        }

        public static bool DeleteCountry(int CountryID)
        {
            return clsCountryDataAccess.DeleteCountry(CountryID);
        }

        public static DataTable GetAllCountries()
        {
            return clsCountryDataAccess.GetAllCountries();
        }

        public static bool IsExists(int CountryID)
        {
            return clsCountryDataAccess.IsExists(CountryID);
        }
        public static bool IsExists(string CountryName)
        {
            return clsCountryDataAccess.IsExists(CountryName);
        }
    }
}
