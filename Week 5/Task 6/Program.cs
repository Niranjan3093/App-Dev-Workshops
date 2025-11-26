using System;

class Program
{
    static void Main(string[] args)
    {
        ElectronicsStore store = new ElectronicsStore();

        Laptop laptop = new Laptop("Dell", 85000);
        Smartphone phone = new Smartphone("Samsung", 45000);

        store.AddDevice(laptop);
        store.AddDevice(phone);

        store.ShowAllDeviceDetails();
    }
}
