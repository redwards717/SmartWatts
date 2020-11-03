using SmartWattsDataAccess.DbModels;
using SmartWattsDataAccess.TableData;
using SmartWattsCore.Models;
using SmartWattsCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWattsUi.Controllers
{
    public class UserController
    {
        private readonly ICyclistData _userData;
        private readonly AppState _appState;

        public UserController(ICyclistData userData, AppState appState)
        {
            _userData = userData;
            _appState = appState;
        }

        public AppState AppState { get; }

        public async Task<string> AddUser(Cyclist newUser)
        {
            return await _userData.InsertUser(newUser);
        }

        public async Task<Cyclist> LoginAttempt(Cyclist user)
        {
            _appState.ToggleLoader(true, "Waking up database");
            var userData = await _userData.Login(user);

            _appState.ToggleLoader(false);

            return userData;
        }

    }
}
