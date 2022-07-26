namespace covali.ComparableCar;

internal class Car:IComparable
{
    public const int MaxSpeed = 100;
    public int CurrentSpeed { get; set; } = 0;
    public string PetName { get; set; } = string.Empty;
    public int CarID { get; set; }

    // private bool carIsDead;

    //private Radio theMusicBox = new Radio();

    public Car()
    {

    }
    public Car(string name, int speed, int carID)
    {
        CurrentSpeed = speed;
        PetName = name;
        CarID = carID;
    }

    public int CompareTo(object? obj)
    {
        Car? temp = obj as Car;
        if (temp != null)
        {
            if (this.CurrentSpeed > temp.CurrentSpeed)
                return 1;
            if (this.CurrentSpeed < temp.CurrentSpeed)
                return -1;
            else
                return 0;
        }
        else
        {
            throw new ArgumentException("Parameter is not a Car");
        }
    }

    //public void CrankTunes(bool state)
    //{
    //    theMusicBox.TurnOn(state);
    //}

    //public void Accelerate(int delta)
    //{
    //    if (delta < 0)
    //    {
    //        throw new
    //            ArgumentOutOfRangeException("delta","Speed must be  greater than zero!");
    //    }
    //    CarIsDeadException ex = new CarIsDeadException($"{PetName} has overheating",
    //        "You have a lead foot",DateTime.Now);

    //    ex.HelpLink = "http://www.test.com";
    //    throw ex;


    //}
}
