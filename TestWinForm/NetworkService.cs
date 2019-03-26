using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using TestWinForm.Object;

namespace TestWinForm
{
    class NetworkService
    {
        public static int GlobalSession { get; set; }
        public static bool IsRequestSuccessful(string jsonResponse)
        {
            ServerResponse serverResponse = ClientJsonConverter.
                GetServerResponse(jsonResponse);
            return serverResponse.Result == ServerResponse.success;

        }
        public static bool Login(UserAccount userAccount)
        {
            TcpClient tcpClient = new TcpClient("127.0.0.1", 6666);
            NetworkStream ns = tcpClient.GetStream();
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);

            string s = ClientJsonConverter.GetLoginRequestJson(userAccount);
            sw.WriteLine(ClientJsonConverter.GetLoginRequestJson(userAccount));
            sw.Flush();
            string jsonResponse = sr.ReadLine();
            if (!IsRequestSuccessful(jsonResponse))
                return false;
            ConnectionInfo connectionInfo = ClientJsonConverter.GetLoginFromResponse(
                jsonResponse);
            if (connectionInfo != null)
            {
                GlobalSession = connectionInfo.Session;
            }

            ns.Close();
            tcpClient.Close();
            return connectionInfo != null;
        }

        public static Student GetStudentPersonalInfo()
        {
            TcpClient tcpClient = new TcpClient("127.0.0.1", 6666);
            NetworkStream ns = tcpClient.GetStream();
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);

            ConnectionInfo connectionInfo = new ConnectionInfo(GlobalSession,
                ConnectionInfo.studentGetPersonalInfo);
            sw.WriteLine(ClientJsonConverter.GetStudentPersonalInfoRequestJson(
                connectionInfo));
            sw.Flush();
            string jsonResponse = sr.ReadLine();
            if (!IsRequestSuccessful(jsonResponse))
                return null;
            Student student = ClientJsonConverter.GetStudentPersonalInfo(
                jsonResponse);

            ns.Close();
            tcpClient.Close();
            return student;
        }

        public static bool InsertStudentCourse(string course_id)
        {
            TcpClient tcpClient = new TcpClient("127.0.0.1", 6666);
            NetworkStream ns = tcpClient.GetStream();
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);

            ConnectionInfo connectionInfo = new ConnectionInfo(GlobalSession,
                ConnectionInfo.studentInsertCourse);
            sw.WriteLine(ClientJsonConverter.GetTeacherPersonalInfoRequestJson(
                connectionInfo));
            sw.Flush();
            string jsonResponse = sr.ReadLine();
            if (!IsRequestSuccessful(jsonResponse))
                return false;

            ns.Close();
            tcpClient.Close();
            return true;
        }

        public static Teacher GetTeacherPersonalInfo()
        {
            TcpClient tcpClient = new TcpClient("127.0.0.1", 6666);
            NetworkStream ns = tcpClient.GetStream();
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);

            ConnectionInfo connectionInfo = new ConnectionInfo(GlobalSession,
                ConnectionInfo.teacherGetPersonalInfo);
            sw.WriteLine(ClientJsonConverter.GetTeacherPersonalInfoRequestJson(
                connectionInfo));
            sw.Flush();
            string jsonResponse = sr.ReadLine();
            if (!IsRequestSuccessful(jsonResponse))
                return null;
            Teacher teacher = ClientJsonConverter.GetTeacherPersonalInfo(
                jsonResponse);

            ns.Close();
            tcpClient.Close();
            return teacher;
        }

        public static bool UpdatePassword(UserAccount userAccount)
        {
            TcpClient tcpClient = new TcpClient("127.0.0.1", 6666);
            NetworkStream ns = tcpClient.GetStream();
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);

            ConnectionInfo connectionInfo = new ConnectionInfo(GlobalSession,
                ConnectionInfo.updatePassword);
            sw.WriteLine(ClientJsonConverter.GetPasswordUpdateRequestJson(
                connectionInfo, userAccount));
            sw.Flush();
            string jsonResponse = sr.ReadLine();
            if (!IsRequestSuccessful(jsonResponse))
                return false;
            ServerResponse serverResponse = ClientJsonConverter.GetServerResponse(jsonResponse);

            ns.Close();
            tcpClient.Close();
            return serverResponse.Result == ServerResponse.success;
        }

        public static IList<Score> GetAllStudentGrades()
        {
            TcpClient tcpClient = new TcpClient("127.0.0.1", 6666);
            NetworkStream ns = tcpClient.GetStream();
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);

            ConnectionInfo connectionInfo = new ConnectionInfo(GlobalSession,
                ConnectionInfo.studentGetGrades);
            sw.WriteLine(ClientJsonConverter.GetGradesRequestJson(
                connectionInfo));
            sw.Flush();
            string jsonResponse = sr.ReadLine();
            if (!IsRequestSuccessful(jsonResponse))
                return null;
            IList<Score> grades = ClientJsonConverter.GetGradesFromResponse(
                jsonResponse);

            ns.Close();
            tcpClient.Close();
            return grades;
        }

        public static Course GetCourseInfo(Course course)
        {
            TcpClient tcpClient = new TcpClient("127.0.0.1", 6666);
            NetworkStream ns = tcpClient.GetStream();
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);

            ConnectionInfo connectionInfo = new ConnectionInfo(GlobalSession,
                ConnectionInfo.studentGetCourseInfo);
            sw.WriteLine(ClientJsonConverter.GetCourseRequestJson(
                connectionInfo, course));
            sw.Flush();
            string jsonResponse = sr.ReadLine();
            if (!IsRequestSuccessful(jsonResponse))
                return null;
            Course resultCourse = ClientJsonConverter.GetCourseFromResponse(
                jsonResponse);

            ns.Close();
            tcpClient.Close();
            return resultCourse;
        }

        public static IList<Course> GetMajorCourses()
        {
            TcpClient tcpClient = new TcpClient("127.0.0.1", 6666);
            NetworkStream ns = tcpClient.GetStream();
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);

            ConnectionInfo connectionInfo = new ConnectionInfo(GlobalSession,
                ConnectionInfo.getMajorCourses);
            sw.WriteLine(ClientJsonConverter.GetMajorCoursesRequestJson(
                connectionInfo));
            sw.Flush();
            string jsonResponse = sr.ReadLine();
            if (!IsRequestSuccessful(jsonResponse))
                return null;
            IList<Course> courses = ClientJsonConverter.GetMajorCoursesFromResponse(
                jsonResponse);

            ns.Close();
            tcpClient.Close();
            return courses;
        }

        public static RoomInfo GetRoomInfo(Room room)
        {
            TcpClient tcpClient = new TcpClient("127.0.0.1", 6666);
            NetworkStream ns = tcpClient.GetStream();
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);

            ConnectionInfo connectionInfo = new ConnectionInfo(GlobalSession,
                ConnectionInfo.getRoomInfo);
            sw.WriteLine(ClientJsonConverter.GetRoomInfoRequestJson(
                connectionInfo, room));
            sw.Flush();
            string jsonResponse = sr.ReadLine();
            if (!IsRequestSuccessful(jsonResponse))
                return null;
            RoomInfo resultRoom = ClientJsonConverter.GetRoomInfoFromResponse(
                jsonResponse);

            ns.Close();
            tcpClient.Close();
            return resultRoom;
        }
        public static IList<Room> GetRoomIdle()
        {
            TcpClient tcpClient = new TcpClient("127.0.0.1", 6666);
            NetworkStream ns = tcpClient.GetStream();
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);

            ConnectionInfo connectionInfo = new ConnectionInfo(GlobalSession,
                ConnectionInfo.getRoomIdle);
            sw.WriteLine(ClientJsonConverter.GetRoomIdleRequestJson(
                connectionInfo));
            sw.Flush();
            string jsonResponse = sr.ReadLine();
            if (!IsRequestSuccessful(jsonResponse))
                return null;
            IList<Room> rooms = ClientJsonConverter.
                GetRoomIdleFromResponse(jsonResponse);

            ns.Close();
            tcpClient.Close();
            return rooms;
        }

        public static IList<Course> GetTeacherCourses()
        {
            TcpClient tcpClient = new TcpClient("127.0.0.1", 6666);
            NetworkStream ns = tcpClient.GetStream();
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);

            ConnectionInfo connectionInfo = new ConnectionInfo(GlobalSession,
                ConnectionInfo.teacherGetCourses);
            sw.WriteLine(ClientJsonConverter.GetTeacherCoursesRequestJson(
                connectionInfo));
            sw.Flush();
            string jsonResponse = sr.ReadLine();
            if (!IsRequestSuccessful(jsonResponse))
                return null;
            IList<Course> courses = ClientJsonConverter.
                GetTeacherCoursesFromResponse(jsonResponse);

            ns.Close();
            tcpClient.Close();
            return courses;
        }

        public static IList<Course> GetCoursesToChoose()
        {
            TcpClient tcpClient = new TcpClient("127.0.0.1", 6666);
            NetworkStream ns = tcpClient.GetStream();
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);

            ConnectionInfo connectionInfo = new ConnectionInfo(GlobalSession,
                ConnectionInfo.studentGetCourseToChoose);
            sw.WriteLine(ClientJsonConverter.GetCoursesToChooseRequestJson(
                connectionInfo));
            sw.Flush();
            string jsonResponse = sr.ReadLine();
            if (!IsRequestSuccessful(jsonResponse))
                return null;
            IList<Course> courses = ClientJsonConverter.
                GetCoursesToChooseFromResponse(jsonResponse);

            ns.Close();
            tcpClient.Close();
            return courses;
        }

        public static IList<Score> GetTeacherCourseGrades(Course course)
        {
            TcpClient tcpClient = new TcpClient("127.0.0.1", 6666);
            NetworkStream ns = tcpClient.GetStream();
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);

            ConnectionInfo connectionInfo = new ConnectionInfo(GlobalSession,
                ConnectionInfo.teacherGetCourseGrades);
            sw.WriteLine(ClientJsonConverter.GetCourseGradesRequestJson(
                connectionInfo, course));
            sw.Flush();
            string jsonResponse = sr.ReadLine();
            if (!IsRequestSuccessful(jsonResponse))
                return null;
            IList<Score> grades = ClientJsonConverter.
                GetCourseGradesFromResponse(jsonResponse);

            ns.Close();
            tcpClient.Close();
            return grades;
        }

        public static bool GetTeacherCourseGrades(IList<Score> grades)
        {
            TcpClient tcpClient = new TcpClient("127.0.0.1", 6666);
            NetworkStream ns = tcpClient.GetStream();
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);

            ConnectionInfo connectionInfo = new ConnectionInfo(GlobalSession,
                ConnectionInfo.teacherUpdateCourseGrades);
            sw.WriteLine(ClientJsonConverter.GetCourseGradesUpdateRequestJson(
                connectionInfo, grades));
            sw.Flush();
            string jsonResponse = sr.ReadLine();
            if (!IsRequestSuccessful(jsonResponse))
                return false;
            ServerResponse serverResponse = ClientJsonConverter.GetServerResponse(
                jsonResponse);

            ns.Close();
            tcpClient.Close();
            return serverResponse.Result == ServerResponse.success;
        }
    }
}
