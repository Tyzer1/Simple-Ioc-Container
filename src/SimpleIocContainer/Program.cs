using SimpleIocContainer;

var container = new IocContainer();

container.Register<IWelcomer, Welcomer>();
container.Register<IWriter, ConsoleWriter>();

var welcomer = container.Create<IWelcomer>();
var writer = container.Create<IWriter>();
welcomer.SayHelloTo("World");
