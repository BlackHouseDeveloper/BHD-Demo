namespace BHD_Demo.Services.Store.Location;

public interface ILocationService
{
    Task UpdateUserLocation(Models.Store.Location.Location newLocReq);
}