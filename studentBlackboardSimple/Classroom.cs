namespace studentBlackboardSimple
{
    public class Classroom
    {
        // has roomNumber, hasProjector, building, computerLab, and nunberOfSeats variables

        private string RoomNumber { get; set; }
        private bool HasProjector { get; set; }
        private string BuildingNumber { get; set; }
        private bool IsComputerLab { get; set; }
        private int NumberOfSeats { get; set; }

        public Classroom(string roomNumber, bool hasProjector, string buildingNumber, bool isComputerLab, int numberOfSeats)
        {
            RoomNumber = roomNumber;
            HasProjector = hasProjector;
            BuildingNumber = buildingNumber;
            IsComputerLab = isComputerLab;
            NumberOfSeats = numberOfSeats;
        }
        public Classroom(string roomNumber, bool hasProjector, string buildingNumber)
        {
            RoomNumber = roomNumber;
            HasProjector = hasProjector;
            BuildingNumber = buildingNumber;
        }
    }
}