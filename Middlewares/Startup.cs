using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Owin;

#region [ listing #1 ]
namespace Middlewares
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
#endregion

#region [ listing #2 ]
//namespace Middlewares
//{
//    public class Startup
//    {
//        public void Configuration(IAppBuilder app)
//        {
//            Func<IDictionary<string, object>, Task> middleware = (IDictionary<string, object> env) =>
//            {
//                Task task = Task.FromResult(0);
//                return task;
//            };

//            app.Use(middleware);
//        }
//    }
//}
#endregion

#region [ listing #3 ]
//namespace Middlewares
//{
//    public class Startup
//    {
//        public void Configuration(IAppBuilder app)
//        {
//            Func<Func<IDictionary<string, object>, Task>, Task> middleware = (Func<IDictionary<string, object>, Task> next) =>
//            {
//                Task task = Task.FromResult(0);
//                return task;
//            };

//            app.Use(middleware);
//        }
//    }
//}
#endregion

#region [ listing #4 ]
//namespace Middlewares
//{
//    public class Startup
//    {
//        public void Configuration(IAppBuilder app)
//        {
//            Func<Func<IDictionary<string, object>, Task>, Func<IDictionary<string, object>, Task>> middleware = (Func<IDictionary<string, object>, Task> next) =>
//            {
//                Func<IDictionary<string, object>, Task> inner = (IDictionary<string, object> env) =>
//                {
//                    Task task = Task.FromResult(0);
//                    return task;
//                };

//                return inner;
//            };

//            app.Use(middleware);
//        }
//    }
//}
#endregion

#region [ listing #5 ]
//namespace Middlewares
//{
//    using AppFunc = Func<IDictionary<string, object>, Task>;

//    public class Startup
//    {
//        public void Configuration(IAppBuilder app)
//        {
//            Func<AppFunc, AppFunc> middleware = (AppFunc next) =>
//            {
//                AppFunc inner = (IDictionary<string, object> env) =>
//                {
//                    Task task = Task.FromResult(0);
//                    return task;
//                };

//                return inner;
//            };

//            app.Use(middleware);
//        }
//    }
//}
#endregion

#region [ listing #6 ]
//namespace Middlewares
//{
//    using AppFunc = Func<IDictionary<string, object>, Task>;

//    public class Startup
//    {
//        public void Configuration(IAppBuilder app)
//        {
//            Func<AppFunc, AppFunc> middleware = (AppFunc next) =>
//            {
//                AppFunc inner = (IDictionary<string, object> env) =>
//                {
//                    Task task = next.Invoke(env);
//                    return task;
//                };

//                return inner;
//            };

//            app.Use(middleware);
//        }
//    }
//}
#endregion

#region [ listing #7 ]
//namespace Middlewares
//{
//    using AppFunc = Func<IDictionary<string, object>, Task>;

//    public class Startup
//    {
//        public void Configuration(IAppBuilder app)
//        {
//            Func<AppFunc, AppFunc> middleware = (AppFunc next) =>
//            {
//                Console.WriteLine("OWIN pipeline is being built");

//                AppFunc inner = (IDictionary<string, object> env) =>
//                {
//                    Console.WriteLine("handling HTTP request");
//                    return next.Invoke(env);
//                };

//                return inner;
//            };

//            Console.WriteLine("adding middleware node");
//            app.Use(middleware);
//        }
//    }
//}
#endregion

#region [ listing #8 ]
//namespace Middlewares
//{
//    using AppFunc = Func<IDictionary<string, object>, Task>;

//    public class Startup
//    {
//        public void Configuration(IAppBuilder app)
//        {
//            Func<AppFunc, AppFunc> middleware = (AppFunc next) =>
//            {
//                Console.WriteLine("retrieving API keys");
//                var apiKeys = new List<string> { "123", "234" };

//                AppFunc inner = (IDictionary<string, object> env) =>
//                {
//                    Console.WriteLine("validating API keys for each HTTP request");
//                    apiKeys.ForEach(k => Console.WriteLine("API key: {0}", k));
//                    return next.Invoke(env);
//                };

//                return inner;
//            };

//            Console.WriteLine("adding middleware node");
//            app.Use(middleware);
//        }
//    }
//}
#endregion

#region [ listing #9 ]
//namespace Middlewares
//{
//    using AppFunc = Func<IDictionary<string, object>, Task>;

//    public class Startup
//    {
//        public void Configuration(IAppBuilder app)
//        {
//            Func<AppFunc, AppFunc> middleware = next => env =>
//            {
//                Console.WriteLine("handling HTTP request");
//                Task task = next.Invoke(env);
//                return task;
//            };

//            Console.WriteLine("adding middleware node");
//            app.Use(middleware);
//        }
//    }
//}
#endregion

#region [ listing #10 ]
//namespace Middlewares
//{
//    using AppFunc = Func<IDictionary<string, object>, Task>;

//    public class Startup
//    {
//        public void Configuration(IAppBuilder app)
//        {
//            Func<AppFunc, AppFunc> middleware = next => async env =>
//            {
//                Console.WriteLine("before");
//                await next.Invoke(env);
//                Console.WriteLine("after");
//            };

//            app.Use(middleware);
//        }
//    }
//}
#endregion

#region [ listing #11 ]
//namespace Middlewares
//{
//    using AppFunc = Func<IDictionary<string, object>, Task>;

//    public class Startup
//    {
//        public void Configuration(IAppBuilder app)
//        {
//            Func<AppFunc, AppFunc> middleware1 = next => async env =>
//            {
//                Console.WriteLine("middleware1 before");
//                await next.Invoke(env);
//                Console.WriteLine("middleware1 after");
//            };

//            Func<AppFunc, AppFunc> middleware2 = next => async env =>
//            {
//                Console.WriteLine("middleware2 before");
//                await next.Invoke(env);
//                Console.WriteLine("middleware2 after");
//            };

//            app.Use(middleware1);
//            app.Use(middleware2);
//        }
//    }
//}
#endregion 

#region [ listing #12 ]
//namespace Middlewares
//{
//    using AppFunc = Func<IDictionary<string, object>, Task>;

//    public class Startup
//    {
//        public void Configuration(IAppBuilder app)
//        {
//            Func<AppFunc, AppFunc> middleware1 = next => async env =>
//            {
//                Console.WriteLine("middleware1 before");
//                await next.Invoke(env);
//                Console.WriteLine("middleware1 after");
//            };

//            Func<AppFunc, AppFunc> middleware2 = next => async env =>
//            {
//                Console.WriteLine("middleware2 before");
//                await next.Invoke(env);
//                Console.WriteLine("middleware2 after");
//            };

//            app.Use(middleware2);
//            app.Use(middleware1);
//        }
//    }
//}
#endregion

#region [ listing #13 ]
//namespace Middlewares
//{
//    using AppFunc = Func<IDictionary<string, object>, Task>;

//    public class Startup
//    {
//        public void Configuration(IAppBuilder app)
//        {
//            app.Use(typeof(Middleware));
//        }
//    }

//    internal class Middleware
//    {
//        private readonly AppFunc _next;

//        public Middleware(AppFunc next)
//        {
//            _next = next;
//        }

//        public Task Invoke(IDictionary<string, object> env)
//        {
//            Console.WriteLine("handling HTTP request");
//            return Task.FromResult(0);
//        }
//    }
//}
#endregion 

#region [ listing #14 ]
//namespace Middlewares
//{
//    using AppFunc = Func<IDictionary<string, object>, Task>;

//    public class Startup
//    {
//        public void Configuration(IAppBuilder app)
//        {
//            app.Use(typeof(Middleware));
//        }
//    }

//    internal class Middleware
//    {
//        private readonly AppFunc _next;

//        public Middleware(AppFunc next)
//        {
//            _next = next;
//        }

//        public async Task Invoke(IDictionary<string, object> env)
//        {
//            Console.WriteLine("before");
//            await _next.Invoke(env);
//            Console.WriteLine("after");
//        }
//    }
//}
#endregion

#region [ listing #15 ]
//namespace Middlewares
//{
//    using AppFunc = Func<IDictionary<string, object>, Task>;

//    public class Startup
//    {
//        public void Configuration(IAppBuilder app)
//        {
//            app.Use(typeof(Middleware), 10, "auth");
//        }
//    }

//    internal class Middleware
//    {
//        private readonly AppFunc _next;
//        private readonly int _number;
//        private readonly string _name;

//        public Middleware(AppFunc next, int number, string name)
//        {
//            _next = next;
//            _number = number;
//            _name = name;
//        }

//        public async Task Invoke(IDictionary<string, object> env)
//        {
//            Console.WriteLine("before. number: {0}, name: {1}", _number, _name);
//            await _next.Invoke(env);
//            Console.WriteLine("after. number: {0}, name: {1}", _number, _name);
//        }
//    }
//}
#endregion

#region [ listing #16 ]
//namespace Middlewares
//{
//    using AppFunc = Func<IDictionary<string, object>, Task>;

//    public class Startup
//    {
//        public void Configuration(IAppBuilder app)
//        {
//            var middleware = new Middleware();
//            app.Use(middleware, 10, "auth");
//        }
//    }

//    internal class Middleware
//    {
//        private AppFunc _next;
//        private int _number;
//        private string _name;

//        public void Initialize(AppFunc next, int number, string name)
//        {
//            _next = next;
//            _number = number;
//            _name = name;
//        }

//        public async Task Invoke(IDictionary<string, object> env)
//        {
//            Console.WriteLine("before. number: {0}, name: {1}", _number, _name);
//            await _next.Invoke(env);
//            Console.WriteLine("after. number: {0}, name: {1}", _number, _name);
//        }
//    }
//}
#endregion
