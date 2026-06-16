namespace RunningTracker.Models
{
    public class Run
    {
        public int Id { get; set; }
        public long StravaActivityId { get; set; }
        public DateTime StartDate { get; set; }
        public float DistanceMeters { get; set; }
        public int MovingTimeSeconds { get; set; }
        public float AveragePaceSecondsPerKm { get; set; }
        public string WorkoutType { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
    }
}