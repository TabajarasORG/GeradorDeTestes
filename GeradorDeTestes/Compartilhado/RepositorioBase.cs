using System.Text.Json;
using System.Text.Json.Serialization;

namespace eAgenda.ConsoleApp.Compartilhado
{
    public abstract class RepositorioBase<T> where T : EntidadeBase
    {
        protected List<T> registros = new List<T>();

        protected int contadorId = 1;

        private string caminho = string.Empty;

        protected RepositorioBase(string nomeArquivo)
        {
            caminho = $"C:\\temp\\GeradorTestes\\{nomeArquivo}.json";

            registros = DeserealizarRegistros();
        }

        public void Cadastrar(T novoRegistro)
        {
            novoRegistro.Id = contadorId++;

            registros.Add(novoRegistro);

            SerealizarRegistros();
        }

        public bool Editar(int id, T novaEntidade)
        {
            T registro = SelecionarPorId(id);

            if (registro == null)
                return false;

            registro.AtualizarRegistro(novaEntidade);

            SerealizarRegistros();

            return true;
        }

        virtual public bool Excluir(int id)
        {
            bool consegiuExcluir =  registros.Remove(SelecionarPorId(id));

            if(!consegiuExcluir) return false;

            SerealizarRegistros();

            return true;
        }

        public List<T> SelecionarTodos()
        {
            return registros;
        }

        public T SelecionarPorId(int id)
        {
            return registros.Find(x => x.Id == id);
        }

        public bool Existe(int id)
        {
            return registros.Any(x => x.Id == id);
        }

        protected void SerealizarRegistros()
        {
            FileInfo arquivo = new(caminho);

            arquivo.Directory.Create();

            JsonSerializerOptions options = new()
            {
                WriteIndented = true,
                ReferenceHandler = ReferenceHandler.Preserve
            };

            byte[] registroEmBytes = JsonSerializer.SerializeToUtf8Bytes(registros, options);

            File.WriteAllBytes(caminho, registroEmBytes);
        }

        protected List<T> DeserealizarRegistros()
        {
            FileInfo arquivo = new(caminho);

            if(!arquivo.Exists)
                return new List<T>();

            byte[] registroEmBytes = File.ReadAllBytes(caminho);

            JsonSerializerOptions options = new()
            {
                ReferenceHandler = ReferenceHandler.Preserve
            };

            List<T> registros = JsonSerializer.Deserialize<List<T>>(registroEmBytes,options);

            return registros;
        }
    }
}
