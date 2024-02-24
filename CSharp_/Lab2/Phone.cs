namespace CShar.Lab2
{
    public abstract class Phone
    {
        public string name;
        public string phone;
        public string newphone;

        
        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Phone1
        {
            get => phone;
            set => phone = value;
        }

        public string Newphone
        {
            get => newphone;
            set => newphone = value;
        }

        public abstract void InserPhone();
        public abstract void RemovePhone();
        public abstract void UpdatePhone();
        public abstract void SearchPhone();
        public abstract void Sort();
        
    }
}