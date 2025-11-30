using TodoServerApp.Data.Interfaces;

namespace TodoServerApp.Data.Services
{
    public class MemoryDataService : IDataService
    {
        private static IEnumerable<TaskItem> tasks = [
            new() {ID = 1, Title ="Задача 1", Description = "Описание задачи 1", CreatedDate=DateTime.Now},
            new() {ID = 2, Title ="Задача 2", Description = "Описание задачи 2", CreatedDate=DateTime.Now},
        ];
        public async Task<IEnumerable<TaskItem>> GetTaskItemsAsync()
        {
            await Task.Delay(1000);
            return await Task.FromResult(tasks);
        }
    }
}
