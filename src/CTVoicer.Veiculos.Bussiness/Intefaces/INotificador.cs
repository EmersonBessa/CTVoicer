using CTVoicer.Veiculos.Bussiness.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace CTVoicer.Veiculos.Bussiness.Intefaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}
