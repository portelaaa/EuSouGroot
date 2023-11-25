Console.WriteLine("...Groot Chatbot...");

const string frasesaida = "tchau";

string questao;
do
{
    Console.Write("Pergunta: ");
    questao = Console.ReadLine()!;

    string resposta = ObtemRespostaGroot(questao);

    ExibeResposta(ObtemRespostaGroot(questao));
    
} while (questao.Trim().ToLower() != frasesaida);

void ExibeResposta (string questao)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"                           Resposta: {questao}");
    Console.ResetColor();
}

string ObtemRespostaGroot(string questao)
{
    return questao.Trim().ToLower() == frasesaida ?
       "Eu sou Groot" :
       "Eu sou Groot.";
       

}
