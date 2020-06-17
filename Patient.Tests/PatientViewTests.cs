using System;
using System.Collections.Generic;
using System.Linq;
using FakeItEasy;
using Infrastructure.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patient.Interfaces.Data;
using Patient.Interfaces.Domain;
using Patient.UI.ViewModels;

namespace Patient.Tests
{
    [TestClass]
    public class PatientViewTests
    {
        [TestMethod]
        public void AllAvailablePatientsAreDisplayedAfterStart()
        {
            var navigationService = A.Fake<INavigationService>();
            var patientRepository = A.Fake<IPatientRepository>();
            A.CallTo(() => patientRepository.GetAll()).Returns(new List<PatientEntity>()
            {
                new PatientEntity() { Firstname = "Hendrik", Lastname = "Lösch"}
            });

            var sut = new PatientViewModel(navigationService, patientRepository);

            sut.Initialize();

            Assert.IsTrue(sut.AvailablePatients.Any());
        }

        [TestMethod]
        public void WeCanNotMoveToNextScreenIfNoPatientIsSelected()
        {
            var navigationService = A.Fake<INavigationService>();
            var patientRepository = A.Fake<IPatientRepository>();
            A.CallTo(() => patientRepository.GetAll()).Returns(new List<PatientEntity>()
            {
                new PatientEntity() { Firstname = "Hendrik", Lastname = "Lösch"}
            });

            var sut = new PatientViewModel(navigationService, patientRepository);
            sut.Initialize();

            Assert.IsFalse(sut.NavigateNextCommand.CanExecute());
        }

        
        [TestMethod]
        public void WeCanMoveToNextScreenIfPatientIsSelected()
        {
            var navigationService = A.Fake<INavigationService>();
            var patientRepository = A.Fake<IPatientRepository>();
            A.CallTo(() => patientRepository.GetAll()).Returns(new List<PatientEntity>()
            {
                new PatientEntity() { Firstname = "Hendrik", Lastname = "Lösch"}
            });

            var sut = new PatientViewModel(navigationService, patientRepository);
            sut.Initialize();

            sut.SelectedPatient = sut.AvailablePatients.First();

            Assert.IsTrue(sut.NavigateNextCommand.CanExecute());
        }
    }
}
