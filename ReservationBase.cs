internal class ReservationBase
{
    public Date date { get; set; }

    public int KoltukNumarasi { get; set; }
    public Location Location { get; set; }
    public User User { get; set; }
}