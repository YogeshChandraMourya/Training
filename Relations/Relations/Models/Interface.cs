namespace Relations.Models
{
    /// <summary>
    /// This class specifies the kind of Room to be Booked
    /// </summary>
    public class RoomTypeM
    {
        public string RoomType { get; set; } = "Luxury";
        public int RoomPrice { get; set; }
        public int DefaultRoomPrice { get; set; }
        public string Rooming { get; set; } = "Spacious";
        public string RoomDescription { get; set; } = "Good";


    }
    public class Room
    {
        int RoomNo { get; set; }
       public Hotel HotelCode { get; set; }

       public RoomTypeM RoomType { get; set; }
       public string Occupancy { get; set; } = "Occupied";
    }

    public class Hotel
    {

       public int HotelCode { get; set; }
        public string HotelName {get; set ;}="Aspire";
        public string Address { get; set; } = "Knowhere";
        public int Postcode { get; set; }
        public string City { get; set; } = "Gotham";
        public string Country { get; set; } = "America";
        public string NumRooms { get; set; } = "Infinite";
        public int PhoneNo { get; set; }
        public int StarRating { get; set; }


    }
    public class Booking
    {
       public int BookingID { get; set; }
        public int GuestID { get; set; }
        public Room RoomNo { get; set; }
        public int BookingDate { get; set; }
        public int BookingTime { get; set; }
        public int ArrivalDate { get; set; }
        public int DepartureDate { get; set; }
        public int EstArrivalTime { get; set; }
        public int EstDepartureTime { get; set; }
        public int NumAdults { get; set; }
        public int NumChildren { get; set; }
        public int SpecialReq { get; set; }
    }







    public class Guest : Booking
    {
      public  int GuestID { get; set; }
        public  string GuestTitle { get; set; } = "DoctorStrange";
      public  string FirstName { get; set; } = "Stephen";
      public  string LastName { get; set; }="Strange";
      public  int DOB { get; set; }
        public  char Gender { get; set; }
        public  int PhoneNo { get; set; }
        public  string Email { get; set; } = "stephen@time.com";
      public  string Password { get; set; } = "timestone";
      public  int PassportNo { get; set; }
        public  string Addess { get; set; } = "Sanctum" ;
      public  int Postcode { get; set; }
        public  string City { get; set; } = "NewYork" ;
        public string Country { get; set; } = "America"  ;

    }


    public class Bill : Booking
    {
      public int InvoiceNo { get; set; }
        public int RoomChange { get; set; }
        public string RoomService { get; set; } = "Provided";
      public int RestaurantCharges { get; set; }
        public int BarCharges { get; set; }
        public int MissCharges { get; set; }
        public string IfLateCheckout { get; set; } = "Notify";
      public string PaymentDate { get; set; } = "date";
      public string PaymentMode { get; set; } = "online/offline";
      public int CreditCardNo{ get; set; }
    public int ExpireDate { get; set; }
        public int ChequeNo { get; set; }
    }
    public class RoleM
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }    
        public string RoleDesc { get; set; }
    }
    public class Employee
    {
        public RoleM RoleID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Hotel HotelCode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
       public int EmployeeID { get; set; }
        public string FirstName { get; set; } = "Tony";
       public string LastName { get; set; } = "Stark";
       public int DOB { get; set; }
        public char Gender { get; set; }
        public int PhoneNo{ get; set; }
        public string Email { get; set; } = "stark@invention.com";
       public string Password { get; set; } = "iamironmman";
        public int Salary { get; set; }

    }





}

