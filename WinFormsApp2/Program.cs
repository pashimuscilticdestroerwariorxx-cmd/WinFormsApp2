using Updatum;

namespace WinFormsApp2
{
    internal static class Program
    {
        //internal static readonly UpdatumManager AppUpdater = new("pashimuscilticdestroerwariorxx", "WinFormsApp2")
        //{
        //    // Можно указать аргументы для тихой установки, например, для MSI
        //    InstallUpdateWindowsInstallerArguments = "/qb"
        //};


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //try
            //{
            //    // 2. Проверка наличия обновлений.
            //    // Возвращает true, если новая версия доступна.
            //    var updateFound = await AppUpdater.CheckForUpdatesAsync();

            //    // Если обновлений нет, завершаем работу.
            //    if (!updateFound)
            //        return;

            //    // 3. Отображение списка изменений (опционально).
            //    //Console.WriteLine("Changelog:");
            //    //Console.WriteLine(AppUpdater.GetChangelog());

            //    // 4. Загрузка обновления во временную папку.
            //    // Возвращает объект с информацией о скачанном файле или null при ошибке.
            //    var downloadedAsset = await AppUpdater.DownloadUpdateAsync();

            //    if (downloadedAsset == null)
            //    {
            //        MessageBox.Show("Не удалось загрузить обновление.");
            //        return;
            //    }

            //    // 5. Запуск установки обновления.
            //    // Этот метод завершит текущий процесс, чтобы обновить файлы приложения.
            //    await AppUpdater.InstallUpdateAsync(downloadedAsset);
            //}
            //catch (Exception ex)
            //{
            //    // Обработка возможных исключений
            //    MessageBox.Show($"Произошла ошибка: {ex.Message}");
            //}



            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}