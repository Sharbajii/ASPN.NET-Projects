namespace TestASP_NET_CORE.Data
{
    public class Task
    {
        public int _taskId { get; set; }

        public string _title { get; set; }

        public DateTime _date { get; set; }

        public bool _isDone { get; set; }

        public Guid _userId { get; set; }
    }
}

