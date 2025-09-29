using EventEase.Models;

namespace EventEase.Services
{
    public class EventService
    {
        private List<EventModel> events = new()
        {
            new EventModel { Id = 1, Name = "Tech Summit", Date = DateTime.Now.AddDays(10), Location = "Manila" },
            new EventModel { Id = 2, Name = "Marketing Meetup", Date = DateTime.Now.AddDays(8), Location = "Manila" },
            new EventModel { Id = 3, Name = "Hackathon", Date = DateTime.Now.AddDays(20), Location = "Cebu" },
            new EventModel { Id = 4, Name = "Business Conference", Date = DateTime.Now.AddDays(18), Location = "Davao" }
        };

        public List<EventModel> GetEvents() => events;

        public EventModel? GetEventById(int id) => events.FirstOrDefault(e => e.Id == id);
    }
}
