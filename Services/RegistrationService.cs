using System.Collections.Generic;

namespace EventEase.Services
{
    public class RegistrationService
    {
        private readonly List<int> registeredEventIds = new();
    private RegistrationModel? lastRegistration;

        public void RegisterEvent(int eventId, RegistrationModel model)
        {
            if (!registeredEventIds.Contains(eventId))
            {
                registeredEventIds.Add(eventId);
                lastRegistration = model;
            }
        }

        public bool IsRegistered(int eventId) => registeredEventIds.Contains(eventId);

        public RegistrationModel? GetLastRegistration() => lastRegistration;

        public List<int> GetRegisteredEventIds() => registeredEventIds;
    }
}
