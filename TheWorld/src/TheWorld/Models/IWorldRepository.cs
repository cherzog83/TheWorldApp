using System.Collections.Generic;
using System.Threading.Tasks;

namespace TheWorld.Models
{
	public interface IWorldRepository
	{
		IEnumerable<Trip> GetAllTrips();
		IEnumerable<Trip> GetUserTripsWithStops(string name);
		IEnumerable<Trip> GetAllTripsWithStops();

		Trip GetTripByName(string tripName, string username);

		void AddTrip(Trip newTrip);
		void AddStop(string tripName, string username, Stop newStop);

		Task<bool> SaveChangesAsync();
	}
}