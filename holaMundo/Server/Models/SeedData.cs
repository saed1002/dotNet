using holaMundo.Shared;
using System.Drawing;
namespace holaMundo.Server.Models
{
	public static class SeedData
	{
		public static void Initialize(PizzaStoreContext context)
		{
			var Specials = new PizzaSpecial[]{
				new PizzaSpecial{
					Name = "Internet",
					Description = "Eventualidades que llegan a suceder al conectarse a internet",
					BasePrice = 189.99m,
					ImageUrl = "images/pizzas/wifi-solid.svg"
				},
				new PizzaSpecial(){
					Name = "Plataformas Internas",
					Description = "Eventualidades que llegan a suceder en las plataformas internas desarrolladas por la compañia",
					BasePrice = 227.99m,
					ImageUrl = "images/pizzas/lightbulb-regular.svg",
				},
				new PizzaSpecial(){
					Name = "Equipo Electronico",
					Description = "Eventualidades que llegan a suceder fisicamente en tu equipo asignado por la compañia",
					BasePrice = 199.50m,
					ImageUrl = "images/pizzas/laptop-medical-solid.svg",
				},
				new PizzaSpecial(){
					Name = "Seguridad",
					Description = "Eventualidades que llegan a suceder en el Sistema de Gestión de la Seguridad de la Información",
					BasePrice = 228.75m,
					ImageUrl = "images/pizzas/shield-halved-solid.svg",
				},
				new PizzaSpecial(){
					Name = "Plataformas Externas",
					Description = "Eventualidades que llegan a suceder en plataformas alojadas y creadas por proveedores",
					BasePrice = 209.00m,
					ImageUrl = "images/pizzas/square-up-right-solid.svg",
				},
				new PizzaSpecial(){
					Name = "Activo Fijo",
					Description = "Eventualidades con el activo fijo de la oficina",
					BasePrice = 190.25m,
					ImageUrl = "images/pizzas/couch-solid.svg",}};
			var Toppings = new Topping[]{
				new Topping{ 
					Name = "Conexión lenta", 
					Price = 47.50m, 
					Description="Cuando tengas dicho problema, verficia que no estes descargando archivos pesados", 
					Type="Internet"},
				new Topping{ 
					Name = "Sin internet", 
					Price = 47.50m,
					Description="Verifica que tu equipo este conectado via cable o wifi correctamente esa opcion la puedes visualizar donde se encuentra la fecha y hora del sistema", 
					Type="Internet"},
				new Topping{
					Name = "No coincide la hora de tu sistema",
					Price = 47.50m,
					Description="Verifica que tu equipo tenga la hora del sistema correctamente sin atrasos o adelantos",
					Type="Internet"},
				new Topping{
					Name = "No me permite acceso a la intranet",
					Price = 47.50m,
					Description="Verifica que en tu bandeja de correo tengas la invitación y correo de acceso a la plataforma",
					Type="Plataformas Internas"},
				new Topping{
					Name = "No recuerdo mi nombre de usuario de la intranet",
					Price = 47.50m,
					Description="Recuerda que tu usuario es tu correo electronico",
					Type="Plataformas Internas"},
				new Topping{
					Name = "Cuanto saldo tengo disponible en el celular asignado",
					Price = 47.50m,
					Description="Todos los colaboradores tienen un plan de 20GB, en caso de requerir mas datos se debera solicitar una nueva orden de compra",
					Type="Equipo Electronico"},
				new Topping{
					Name = "Puedo usar el roaming de mi celular asignado",
					Price = 47.50m,
					Description="Todos los colaboradores tienen un plan de 20GB, en este caso no es posible por parte de proveedor por el momento",
					Type="Equipo Electronico"},
				new Topping{
					Name = "Tarda mucho la bateria en cargar",
					Price = 47.50m,
					Description="Deberas de solicitar una orden de compra para compra de accesorios para tu equipo electronico",
					Type="Equipo Electronico"},
				new Topping{
					Name = "Como se que los correos que me llegan no son pishing",
					Price = 47.50m,
					Description="la direccion de correo oficial de la compañia es @buzzsolutions.com, nunca enviaremos correos solicitando dinero",
					Type="Seguridad"},
				new Topping{
					Name = "Como recuperar mi contraseña olvidad",
					Price = 47.50m,
					Description="Solicita una nueva enviando un correo a intranetsupport@buzzsolutions.com, debe de tener la contraseña 8 caracteres minimo, 1 caracter, 1 numero, 1 letra, 1 mayuscula",
					Type="Seguridad"},
				new Topping{
					Name = "Como puede el cliente accesar a las oficinas",
					Price = 47.50m,
					Description="Se debe solicitar permiso a la area de seguridad enviando un correo seguridad@buzzsolutions.com",
					Type="Seguridad"},
			};
			context.Toppings.AddRange(Toppings);
			context.Specials.AddRange(Specials);
			context.SaveChanges();
		}

	}
}

