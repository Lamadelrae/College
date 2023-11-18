import React, { useState } from "react";
import { Alert, Keyboard, TouchableWithoutFeedback } from "react-native";
import { Button } from "../../components/Button";
import { Header } from "../../components/Header";
import { Input } from "../../components/Input";
import { Container } from "./styles";
import { InputAmount } from "../../components/InputAmount";
import { InputDate } from "../../components/InputDate";
import { addSale } from "../../storage/sales/createSale";
import { formatAmount } from "../../utils/formatAmount";
import { validateCpf } from "../../utils/validateCpf";
import { SaleDTO } from "../../storage/sales/SaleDTO";

export function Dashboard() {
  const [cpf, setCpf] = useState("");
  const [product, setProduct] = useState("");
  const [value, setValue] = useState("");
  const [date, setDate] = useState("");

  async function handleAddNewSale() {
    const cpfValidated = validateCpf(cpf);

    if (!cpfValidated) {
      return Alert.alert("CPF inválido!", "Digite um CPF válido.");
    }
    if (!product) {
      return Alert.alert("Produto inválido!", "Digite o produto da venda.");
    }
    if (!value) {
      return Alert.alert("Valor inválido!", "Digite o valor da venda.");
    }
    if (!date) {
      return Alert.alert("Data inválida", "Digite a data da venda.");
    }

    const data: SaleDTO = {
      cpf,
      value: formatAmount(value),
      product,
      date,
    };

    await addSale(data);

    setCpf("");
    setProduct("");
    setValue("");
    setDate("");

    return Alert.alert("Venda adicionada com sucesso!");
  }

  return (
    <TouchableWithoutFeedback onPress={Keyboard.dismiss} accessible={false}>
      <Container>
        <Header title="Controle de Vendas" />

        <Input
          placeholder="CPF do Vendedor"
          placeholderTextColor="#363F5F"
          value={cpf}
          onChangeText={(value) => setCpf(value)}
        />

        <Input
          placeholder="Produto"
          placeholderTextColor="#363F5F"
          value={product}
          onChangeText={(value) => setProduct(value)}
        />

        <InputAmount
          placeholder="Valor da Venda"
          placeholderTextColor="#363F5F"
          value={value}
          onChangeText={(value) => setValue(value)}
        />

        <InputDate
          placeholder="Data da Venda"
          placeholderTextColor="#363F5F"
          value={date}
          onChangeText={(value) => setDate(value)}
        />

        <Button title="Adicionar" onPress={handleAddNewSale} />
      </Container>
    </TouchableWithoutFeedback>
  );
}
