using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.Compartilhado
{
    public interface IControladorVisualizar
    {
        string ToolTipVisualizarTeste {  get; }
        void VisualizarTeste();
    }
}
