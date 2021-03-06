// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnityFactory0.cs" company="Pedro Pombeiro">
//   2012 Pedro Pombeiro
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Unity.AutoFactory.Implementation
{
    using System;

    /// <summary>
    /// Implementation of a Unity auto-factory which returns a new <typeparam name="T">instance of T</typeparam>.
    /// </summary>
    /// <typeparam name="T">
    /// The type returned by the factory.
    /// </typeparam>
    internal class UnityFactory0<T> : IUnityFactory<T>
    {
        #region Fields

        /// <summary>
        /// The delayed-resolution lambda provided by Unity which can create an instance of <see cref="T"/>.
        /// </summary>
        private readonly Func<T> unityFactoryDelegate;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="UnityFactory0{T}"/> class. 
        /// </summary>
        /// <param name="unityFactoryDelegate">
        /// The delayed-resolution lambda provided by Unity which can create an instance of <see cref="T"/>.
        /// </param>
        public UnityFactory0(Func<T> unityFactoryDelegate)
        {
            this.unityFactoryDelegate = unityFactoryDelegate;
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// Creates an instance of type <see cref="T"/> through the Unity container.
        /// </summary>
        /// <returns>A new instance of <see cref="T"/>.</returns>
        public T Create()
        {
            return this.unityFactoryDelegate();
        }

        #endregion
    }
}