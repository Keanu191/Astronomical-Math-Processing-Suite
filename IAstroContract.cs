/*
 * 30074191 / Keanu Farro
 * 8/10/2024
 */
using System.ServiceModel;

namespace MalinAstroAPP
{
    /// <summary>
    /// Defines the WCF service contract for astronomical calculations.
    /// </summary>
    [ServiceContract]
    public interface IAstroContract
    {
        /// <summary>
        /// Converts a temperature from Celsius to Kelvin.
        /// </summary>
        /// <param name="tempInCelsius">The temperature in Celsius.</param>
        /// <returns>The temperature in Kelvin.</returns>
        [OperationContract]
        double tempConversion(double tempInCelsius);

        /// <summary>
        /// Calculates the velocity of a star based on observed and rest wavelengths.
        /// </summary>
        /// <param name="observedWaveLength">The observed wavelength of the star.</param>
        /// <param name="restWaveLength">The rest wavelength of the star.</param>
        /// <returns>The velocity of the star.</returns>
        [OperationContract]
        double measureVelocity(double observedWaveLength, double restWaveLength);

        /// <summary>
        /// Calculates the distance to a star based on its angular size in arcseconds.
        /// </summary>
        /// <param name="arcSecondsAngle">The angular size of the star in arcseconds.</param>
        /// <returns>The distance to the star.</returns>
        [OperationContract]
        double calculateStarDistance(double arcSecondsAngle);

        /// <summary>
        /// Calculates the radius of the event horizon of a black hole based on its mass.
        /// </summary>
        /// <param name="blackHoleMass">The mass of the black hole.</param>
        /// <returns>The radius of the event horizon.</returns>
        [OperationContract]
        double calculateEventHorizon(double blackHoleMass);

        /// <summary>
        /// Checks the connectivity of the WCF service.
        /// </summary>
        /// <returns>True if the service is reachable; otherwise, false.</returns>
        [OperationContract]
        bool Ping();
    }
}
