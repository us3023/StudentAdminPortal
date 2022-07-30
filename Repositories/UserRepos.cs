using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using StudentAdminPortal.DataModels;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdminPortal.Repositories
{
    public class UserRepos : IUserRepos
    {
        private readonly StudentAdminContext _db;
        private readonly AppSettings _appSettings;

        public UserRepos(StudentAdminContext db,IOptions<AppSettings>appsettings)
        {
            _db = db;
            _appSettings = appsettings.Value;
        }
        public User Authenticate(string username, string password)
        {
            var user = _db.Users.SingleOrDefault(x => x.Username == username && x.Passeword == password);
            if (user==null)
            {
                return null;
            }
            //jwt 
            /*var tokenhandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[] {

                    new Claim(ClaimTypes.Name,user.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenhandler.CreateToken(tokenDescriptor);
            user.Token = tokenhandler.WriteToken(token);*/
            return user;
        }

        public bool IsUniqueUser(string username)
        {
            throw new NotImplementedException();
        }

        public User Register(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
