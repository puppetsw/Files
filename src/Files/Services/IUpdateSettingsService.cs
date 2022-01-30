using System;
using System.ComponentModel;

namespace Files.Services
{
    public interface IUpdateSettingsService : IBaseSettingsService, INotifyPropertyChanged
    {
        /// <summary>
        /// Gets or sets a value indicating whether [mandatory only].
        /// </summary>
        /// <value><c>true</c> if [mandatory only]; otherwise, <c>false</c>.</value>
        bool MandatoryOnly { get; set; }

        /// <summary>
        /// Occurs when [updates are available event].
        /// </summary>
        event EventHandler UpdateAvailableEvent;

        /// <summary>
        /// Gets a value indicating whether [are updates available].
        /// </summary>
        /// <value><c>true</c> if [are updates available]; otherwise, <c>false</c>.</value>
        bool IsUpdateAvailable { get; }

        /// <summary>
        /// Downloads the updates.
        /// </summary>
        void DownloadUpdates();

        /// <summary>
        /// Checks for updates.
        /// </summary>
        void CheckForUpdates();
    }
}