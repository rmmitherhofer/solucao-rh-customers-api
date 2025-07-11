﻿using Api.Responses;

namespace Solucao.RH.Customers.Api.Dto.Responses;

/// <summary>
/// Contato
/// </summary>
public class ContactResponse : Response
{
    /// <summary>
    /// Id
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Nome do contato
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Numero do telefone
    /// </summary>
    public string? Telephone { get; set; }
    /// <summary>
    /// Numero de celular
    /// </summary>
    public string? CellPhone { get; set; }
    /// <summary>
    /// Numero de Whatsapp
    /// </summary>
    public string? WhatsApp { get; set; }
    /// <summary>
    /// Endereço de e-mail
    /// </summary>
    public string? Email { get; set; }
    /// <summary>
    /// Departamento de atuação
    /// </summary>
    public string? Department { get; set; }
    /// <summary>
    /// Posição ou cargo do responsavel
    /// </summary>
    public string? Position { get; set; }
    /// <summary>
    /// Removido logicamente
    /// </summary>
    public bool IsDeleted { get; set; }
}


/// <summary>
/// Contatos
/// </summary>
public class ContactsResponse(Guid customerId)
{
    /// <summary>
    /// Id do cliente
    /// </summary>
    public Guid CustomerId => customerId;
    /// <summary>
    /// Lista de contatos
    /// </summary>
    public ICollection<ContactResponse>? Contacts { get; set; }
}