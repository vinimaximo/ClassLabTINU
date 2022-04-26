-- Criação de procedures
use comercialdb0191


-----------------------------------
-- Procedure de inserir cliente --
-----------------------------------
delimiter  |
CREATE PROCEDURE sp_clientes_inserir(
_nome varchar(60),
_cpf varchar(11),
_email varchar(60)
)
BEGIN
	insert into clientes (nome, cpf, email, datacad, ativo)
	values (_nome, _cpf, _email, default, default);
    select * from clientes where idcli = (select @@identity);
end
|

-----------------------------------
-- Procedure de alterar cliente --
-----------------------------------
delimiter |
create procedure alterar_clientes(
_id int,
_nome varchar (60),
_email char(60),
_ativo bit(1)
)
begin
	update clientes set nome = _nome, email = _email, ativo = _ativo where idcli = _id;
end |

-----------------------------------
-- Procedure de inserir Produtos --
-----------------------------------

delimiter  |
CREATE PROCEDURE sp_produtos_inserir(
_descricao varchar(100),
_unidade varchar(14),
_codbar varchar(13),
_valor decimal(10,2)
)
BEGIN
	insert into produtos (descricao, unidade, codbar, valor, desconto,descontinuado)
	values (_descricao, _unidade, _codbar, _valor, 0, default);
    select * from produtos where idprod = (select @@identity);
end
|

-----------------------------------
-- Procedure de alterar produtos --
-----------------------------------
delimiter |
create procedure alterar_produtos(
_id int,
_valor decimal(10,2),
_desconto decimal(10,2)
)
begin
	update produtos set valor = _valor, desconto = _desconto where idprod = _id;
end |

-----------------------------------
-- Procedure de inserir usuarios --
-----------------------------------

delimiter |
create procedure usuarios_inserir(
_nome varchar (60),
_email varchar (60),
_senha varchar (32)
)
begin
	insert into usuarios (nome, email, senha,  ativo)
	values (_nome, _email, (md5(_senha)), default);
	select * from usuarios where iduser = (select @@identity);
end |
select * from usuarios
-----------------------------------
-- Procedure de alterar usuarios --
-----------------------------------
delimiter |
create procedure alterar_usuarios(
_id int,
_nome varchar(60),
_email varchar(60),

_ativo bit (1)
)
begin
	update usuarios set nome = _nome, email = _email, senha = md5(_senha),   ativo = _ativo where iduser = _id;
end |

    
-----------------------------------
-- Procedure de inserir pedidos --
-----------------------------------
delimiter |
create procedure pedidos_inserir(
_status_ped varchar (15),
_desconto decimal (10,2),
_idcli_ped int,
_iduser_ped int
)
begin
	insert into pedidos (data, status_ped, desconto, idcli_ped, iduser_ped)
	values (default, _status_ped, _desconto, _idcli, _iduser);
	select * from pedidos where idped = (select @@identity);
end |

-----------------------------------
-- Procedure de alterar pedidos --
-----------------------------------
delimiter |
create procedure alterar_pedidos(
_id int,
_status_ped varchar (15),
_desconto decimal (10,2)

)
begin
	update pedidos set  status_ped = _status_ped, desconto = _desconto where idped = _id;
end |

-----------------------------------
-- Procedure de inserir itempedido --
-----------------------------------
delimiter |
create procedure itempedido_inserir(
_idped_ip int,
_idprod_ip int,
_valor decimal (10,2),
_quantidade decimal (10,2),
_desconto decimal (10,2)
)
begin
	insert into itempedido (idped_ip, idprod_ip, valor, quantidade, desconto)
	values (_idped, _idprod, _valor, _quantidade, _desconto);
	end |
    
-----------------------------------
-- Procedure de alterar itempedido --
-----------------------------------
delimiter |
create procedure alterar_itempedido(
_idped_ip int,
_idprod_ip int,
_valor decimal(10,2),
_quantidade decimal(10,2),
_desconto decimal(10,2)
)
begin
	update itempedido set  valor = _valor, quantidade = _quantidade, desconto = _desconto where idped = _idped and idprod = _idprod;
end |

-----------------------------------
-- Procedure de inserir caixas --
-----------------------------------
delimiter |
create procedure caixas_inserir(
_saldo decimal(10,2),
_status_caixa varchar(32),
_iduser_cx int
)
begin
	insert into caixas (_saldo, _status_caixa, _iduser_cx )
	values (default, _saldo, _status_caixa, _iduser_cx );
    select * from caixas where idcx = (select @@identity);
	end |
    
-----------------------------------
-- Procedure de alterar caixa --
-----------------------------------
delimiter |
create procedure alterar_caixas(
_id int,
_saldo decimal(10,2),
_status_caixa varchar(32),
_iduser_cx int
)
begin
	update caixas set  saldo = _saldo, status_caixa = _status_caixa where idcx = _id  ;
end |

-----------------------------------
-- Procedure de inserir vendas --
-----------------------------------
delimiter |
create procedure vendas_inserir(
_status_vnd varchar(15),
_desconto decimal(10,2),
_idcx_vnd int,
_idped_vnd int
)
begin
	insert into vendas (data_vnd, status_vnd, desconto, idcx_vnd, idped_vnd )
	values (default, _status_vnd, _desconto, _idcs_vnd, idped_vnd );
    select * from vendas where idvnd = (select @@identity);
	end |
    
----------------------------------
-- Procedure de alterar vendas --
-----------------------------------
delimiter |
create procedure alterar_vendas(
_id int,
_status_vnd varchar (15),
_desconto decimal(10,2)
)
begin
	update vendas set  status_vnd = _status_vnd, desconto = _desconto where idvnd = _id ;
end |

-----------------------------------
-- Procedure de inserir pagamentos --
-----------------------------------
delimiter |
create procedure pagamentos_inserir(
_valor decimal(10,2),
idvnd_pag int,
idtipo_pag int
)
begin
	insert into pagamentos (valor, idvnd_pag, idtipo_pag )
	values (_valor, _idvnd_pag, _idtipo_pag );
    select * from pagamentos where idpag = (select @@identity);
	end |
    
----------------------------------
-- Procedure de alterar pagamentos --
-----------------------------------
delimiter |
create procedure alterar_pagamentos(
_id int,
_valor decimal (10,2)
)
begin
	update pagamentos set  valor = _valor where idpag = _id ;
end |

-----------------------------------
-- Procedure de inserir tipos --
-----------------------------------
delimiter |
create procedure tipos_inserir(
_nome varchar(20),
_sigla varchar(10)
)
begin
	insert into tipos (nome, sigla)
	values (_nome, _sigla );
    select * from tipos where idpag = (select @@identity);
	end |
    
----------------------------------
-- Procedure de alterar tipos --
-----------------------------------
delimiter |
create procedure alterar_tipos(
_id int,
_nome varchar (20),
_sigla varchar (10) 
)
begin
	update tipos set  nome = _nome, sigla = _sigla where idtipo = _id ;
end |

-----------------------------------
-- Procedure de inserir niveis --
-----------------------------------
delimiter |
create procedure niveis_inserir(
_nome varchar(45),
_sigla varchar(5)
)
begin
	insert into niveis (nome, sigla)
	values (_nome, _sigla );
    select * from tipos where idnv = (select @@identity);
	end |
    
----------------------------------
-- Procedure de alterar niveis --
-----------------------------------
delimiter |
create procedure alterar_niveis(
_id int,
_nome varchar (45),
_sigla varchar (5) 
)
begin
	update niveis set  nome = _nome, sigla = _sigla where idnv = _id ;
end |










------------------------------------------------------------------------------------------------------------------
call sp_produtos_inserir(' Amortecedor dianteiro Kofap para Celta ', 'par', '7894451231458', 376.68);

select * from clientes;










































































