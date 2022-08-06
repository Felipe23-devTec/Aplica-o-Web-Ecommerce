class Carrinho{
    ClickIncremento(btn) {
        let data = this.getData(btn);
        data.Quantidade++;
        this.postQuantidade(data);
        setTimeout(function () {
            window.location.reload();
        }, 500);
        

    }
    ClickDecremento(btn) {
        let data = this.getData(btn);
        data.Quantidade--;
        this.postQuantidade(data);
        setTimeout(function () {
            window.location.reload();
        }, 500);
    }
    updateQuantidade(input) {
        let data = this.getData(input);
        if (data.Quantidade != '') {
            this.postQuantidade(data);
            setTimeout(function () {
                window.location.reload();
            }, 500);
        }
        
        debugger;
    }
    getData(elemento) {
        var linhaDoitem = $(elemento).parents('[item-id]');
        var itemId = $(linhaDoitem).attr('item-id');
        var qtdItem = $(linhaDoitem).find('input').val();
        return  {
            IdItemPedido: itemId,
            Quantidade: qtdItem
        };
    }
    postQuantidade(data) {
        $.ajax({
            url: '/Pedidos/UpdateQuantidade',
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(data)
        });
    }
}
var carrinho = new Carrinho();