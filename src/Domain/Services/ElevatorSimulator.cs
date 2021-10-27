using System.Threading.Tasks;
using Domain.Interfaces;

namespace Domain.Services
{
    public class ElevatorSimulator : IElevatorSimulator
    {
        private const int MILLISECONDS_INTERVAL_TO_GENERATE_RANDOM_COMMAND = 20000;
        private const int MILLISECONDS_TO_MOVE_BEETWEEN_FLOORS = 2000;
        private const int MILLISECONDS_TO_VISIT_FLOOR = 4000;

        public int MillisecondsIntervalToGenerateRandomCommand => MILLISECONDS_INTERVAL_TO_GENERATE_RANDOM_COMMAND;
        public int MillisecondsToMoveBeetweenFloors => MILLISECONDS_TO_MOVE_BEETWEEN_FLOORS;

        public async Task SimulateFloorVisit()
        {
            await Task.Delay(MILLISECONDS_TO_MOVE_BEETWEEN_FLOORS);
        }

        public async Task SimulateMoveToNextFloor()
        {
            await Task.Delay(MILLISECONDS_TO_VISIT_FLOOR);
        }
    }
}