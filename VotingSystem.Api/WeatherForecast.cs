using System;

namespace VotingSystem.Api
{
    public class WeatherForecast
    {
        /// <summary>
        /// ����
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// ��ǰ�¶�
        /// </summary>
        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}