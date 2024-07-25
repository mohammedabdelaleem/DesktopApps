
using DataAccessLayer;
using System.Data;
namespace BuissnessLayer
{
    public class clsPlayer
    {


        #region Properties and Attributes
        enum enMode { AddNew, Update }
        enMode Mode = enMode.AddNew;

        public int ID { private set; get; } // auto generation
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public int Win { set; get; }
        public int Loss { set; get; }
        public int Draw { set; get; }

        #endregion

        #region Constructors

        public clsPlayer()
        {
            this.ID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.Win = 0;
            this.Loss = 0;
            this.Draw = 0;
            Mode = enMode.AddNew;

        }

        // why private
        // Id Is an auto number 
        // you can't genaarte a clsContact object from outside using id 
        // find returns to you the object status with id
        private clsPlayer(int ID, string FirstName, string LastName,
            int Win, int Loss, int Draw)
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Win = Win;
            this.Loss = Loss;
            this.Draw = Draw;

            Mode = enMode.Update;
        }

        #endregion


        #region Methods

        public static clsPlayer Find(string FirstName, string LastName)
        {

            int ID = 0, Win = 0, Loss = 0, Draw = 0;
           
            if (clsPlayersDataAccess.GetPlayerInfoByName(ref ID, FirstName, LastName,
                ref Win, ref Loss, ref Draw))
                return new clsPlayer(ID, FirstName, LastName, Win, Loss , Draw );

            else return null;
        }

        private bool _AddNewPlayer()
        {
            // save is an member method , so we have the full object ==> we can use its data members
            // id is an auto number
            this.ID = clsPlayersDataAccess.AddNewPlayer(this.FirstName, this.LastName, this.Win, this.Loss, this.Draw);

            return this.ID != -1;
        }


        private bool _UpdatePlayer()
        {
            return clsPlayersDataAccess.UpdatePlayer(this.ID, this.FirstName, this.LastName, this.Win, this.Loss, this.Draw);
        }


        public bool Save()
        {
            switch (Mode)
            {

                case enMode.AddNew:
                    if (_AddNewPlayer())
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdatePlayer();

            }

            return false;
        }


        public static DataView GetAllPlayers()
        {
            return clsPlayersDataAccess.GetAllPlayers();
        }

        public static DataView GetAllPlayersNames()
        {
            return clsPlayersDataAccess.GetAllPlayersNames();
        }


        public static bool IsExists(string FirstName, string LastName)
        {
            return clsPlayersDataAccess.IsExists( FirstName, LastName);
        }
        #endregion

    }
}
