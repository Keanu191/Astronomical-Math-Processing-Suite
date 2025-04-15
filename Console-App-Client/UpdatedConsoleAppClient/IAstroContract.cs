using System;
using System.ServiceModel;

namespace UpdatedConsoleAppClient
{
    /// <summary>
    /// Defines the contract for the AstroServer WCF service.
    /// Provides methods for performing various astronomical calculations.
    /// </summary>
    [ServiceContract]
    internal interface IAstroContract
    {
        /// <summary>
        /// Converts a temperature from Celsius to Kelvin.
        /// </summary>
        /// <param name="tempInCelsius">The temperature in degrees Celsius.</param>
        /// <returns>The equivalent temperature in Kelvin.</returns>
        [OperationContract]
        double tempConversion(double tempInCelsius);

        /// <summary>
        /// Calculates the velocity of a star based on its observed and rest wavelengths.
        /// </summary>
        /// <param name="observedWaveLength">The observed wavelength of the star.</param>
        /// <param name="restWaveLength">The rest wavelength of the star.</param>
        /// <returns>The velocity of the star in appropriate units.</returns>
        [OperationContract]
        double measureVelocity(double observedWaveLength, double restWaveLength);

        /// <summary>
        /// Calculates the distance to a star based on its angular size in arcseconds.
        /// </summary>
        /// <param name="arcSecondsAngle">The angular size of the star in arcseconds.</param>
        /// <returns>The distance to the star in parsecs.</returns>
        [OperationContract]
        double calculateStarDistance(double arcSecondsAngle);

        /// <summary>
        /// Calculates the radius of the event horizon of a black hole based on its mass.
        /// </summary>
        /// <param name="blackHoleMass">The mass of the black hole.</param>
        /// <returns>The radius of the event horizon in meters.</returns>
        [OperationContract]
        double calculateEventHorizon(double blackHoleMass);
    }
}
