namespace Atividade
{
    class Pessoa_Juridica : Clientes
    {
        public string cnpj { get; set; }
        public string ie { get; set; }

        public override void Pagar_Imposto(float v)
        {
            this.valor = v;
            this._imposto = this.valor * 20 / 100;
            this.total = this.valor + this._imposto;
        }
    }
}
