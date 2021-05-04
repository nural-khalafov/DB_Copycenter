namespace DB_Copycenter
{
    public class Service
    {
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public int ServiceCost { get; set; }

        public Service()
        {
            
        }

        public Service(int serviceId, string serviceName, int serviceCost)
        {
            this.ServiceId = serviceId;
            this.ServiceName = serviceName;
            this.ServiceCost = serviceCost;
        }

        public Service(Service service)
        {
            this.ServiceId = service.ServiceId;
            this.ServiceName = service.ServiceName;
            this.ServiceCost = service.ServiceCost;
        }
    }
}