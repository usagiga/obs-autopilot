namespace obs_autopilot.Configs
{
    public class ObsConnectInfo
    {
        string host = "localhost";
        int port = 4455;
        string password;

        public (string, string) GetConnectInfo()
        {
            return ($"ws://{Host}:{Port}", Password);
        }
        
        public string Host
        {
            get => host;
            set
            {
                if (!validateHost(value)) return;
                host = value;
            }
        }

        public int Port
        {
            get => port;
            set
            {
                if (!validatePort(value)) return;
                port = value;
            }
        }
        
        public string Password {
            get => password;
            set
            {
                if (!validatePassword(value)) return;
                password = value;
            }
        }

        private bool validateHost(string value) => !string.IsNullOrWhiteSpace(value);
        
        private bool validatePort(int value) => !(0 <= value && value <= 65535);
        
        private bool validatePassword(string value) => !string.IsNullOrWhiteSpace(value);

        public bool Validate() => validateHost(Host) && validatePort(Port) && validatePassword(Password);
    }
}