using System.Runtime.InteropServices;

namespace win_crud.Utils;
public static class MdiProperties
{
    [DllImport("user32.dll")]
    private static extern int SetWindowLong(IntPtr hWnd, int index, int value);

    [DllImport("user32.dll")]
    private static extern int GetWindowLong(IntPtr hWnd, int index);

    [DllImport("user32.dll")]
    private static extern int SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

    /// <summary>
    /// Este valor representa o índice para a definição do estilo estendido de uma janela. 
    /// É usado nas funções GetWindowLong e SetWindowLong para obter e definir o estilo estendido de uma janela.
    /// </summary>
    private const int GWL_EXSTYLE = -20;

    /// <summary>
    /// Este valor representa um estilo de borda estendida de uma janela, que exibe uma borda em estilo 3D ao redor do perímetro de uma janela. 
    /// É frequentemente usado para dar uma aparência mais destacada a uma janela.
    /// </summary>
    private const int WS_EX_CLIENTEDGE = 0x200;

    /// <summary>
    /// Esses valores são flags que controlam o comportamento da função "SetWindowPos", que é usada para alterar a posição e o tamanho de uma janela. 
    /// Cada um desses valores especifica um aspecto diferente do comportamento da janela durante a alteração de posição ou tamanho
    /// </summary>
    private const uint SWP_NOSIZE = 0x0001;
    private const uint SWP_NOMOVE = 0x0002;
    private const uint SWP_NOZORDER = 0x0004;
    private const uint SWP_NOACTIVATE = 0x0010;
    private const uint SWP_FRAMECHANGED = 0x0020;

    /// <summary>
    /// Esta é uma flag que controla como as janelas filhas são reorganizadas em relação às janelas pai quando uma janela é redimensionada ou movida. 
    /// Ela controla se as janelas filhas devem ser reorganizadas em relação à janela pai durante uma operação de redimensionamento ou movimento.
    /// </summary>
    private const uint SWO_NOOWNERZORDER = 0X0200;

    public static bool SetBevel(this Form form, bool show)
    {
        foreach(Control c in form.Controls) {
            MdiClient? client = c as MdiClient;
            if (client is not null)
            {
                int windowLong = GetWindowLong(c.Handle, GWL_EXSTYLE);
                if (show)
                    windowLong |= WS_EX_CLIENTEDGE;
                else
                    windowLong &= ~WS_EX_CLIENTEDGE;

                _ = SetWindowLong(c.Handle, GWL_EXSTYLE, windowLong);
                _ = SetWindowPos(client.Handle, IntPtr.Zero, 0, 0, 0, 0,
                    SWP_NOACTIVATE | SWP_NOMOVE | SWP_NOSIZE | SWP_NOZORDER |
                    SWO_NOOWNERZORDER | SWP_FRAMECHANGED
                    );
                return true;
            }
        }
        return false;
    }

}
