using ScreenSound;

Episodio episodio1 = new Episodio(1, "Técnicas de Facilitação", 45);
episodio1.AdicionarConvidado("João");
episodio1.AdicionarConvidado("Maria");
episodio1.AdicionarConvidado("José");
Console.WriteLine(episodio1.Resumo);

Episodio episodio2 = new Episodio(2, "Técnicas de Feedback", 60);
episodio2.AdicionarConvidado("Ana");
episodio2.AdicionarConvidado("Carlos");
Console.WriteLine(episodio2.Resumo);

Podcast podcast = new Podcast("ScrumCast", "Rafael");
podcast.AdicionarEpisodio(episodio1);
podcast.AdicionarEpisodio(episodio2);
podcast.ExibirDetalhes();