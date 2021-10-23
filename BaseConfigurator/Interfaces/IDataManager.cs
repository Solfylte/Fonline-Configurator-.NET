using System.Collections.Generic;

namespace Configurator
{
    /// <summary>
    /// Responsible for IO the configuration file and interpreting data as config sections.
    /// *Doesn't implement manipulating concrete configuration fields (see IConfigManager for this).
    /// </summary>
    public interface IDataManager
    {
        /// <summary>
        /// Returns a dictionary with strings key-value configuration pairs.
        /// </summary>
        /// <param name="header"> Used if config file divided by separate section with headers, like [iHeader]</param>
        Dictionary<string, string> GetConfigSection(string header = "");

        /// <summary>
        /// Sets the passed configuration key-values to the config file.
        /// </summary>
        /// <param name="configSection">Dictionary with strings key-value configuration pairs</param>
        /// <param name="header">Used if config file divided by separate section with headers, like [iHeader].
        /// Empty if uses just one section for all config file.</param>
        void SetConfigSection(Dictionary<string, string> configSection, string header = "");

        string[] GetHeaders();
    }
}