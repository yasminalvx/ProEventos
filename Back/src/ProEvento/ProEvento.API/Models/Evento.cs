namespace ProEvento.API.Models
{ 
	public class Evento
	{
		public int EventoId { get; set; }

		public string EventoLocal { get; set; }

		public string EventoDate { get; set; }

		public string TemaEvento { get; set; }

		public int QtdPessoasEvento { get; set; }

		public string LoteEvento { get; set; }

		public string ImagemUrlEvento { get; set; }
	}


}

