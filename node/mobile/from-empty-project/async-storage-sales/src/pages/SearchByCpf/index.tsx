import React, { useState } from "react";
import { Header } from "../../components/Header";
import { Container, Transactions, TextCard } from "./styles";
import { Input } from "../../components/Input";
import { Button } from "../../components/Button";
import {
  Alert,
  FlatList,
  Keyboard,
  TouchableWithoutFeedback,
} from "react-native";
import { getAllSales } from "../../storage/sales/getAllSales";
import { SaleDTO } from "../../storage/sales/SaleDTO";
import { ListSaleCard } from "../../components/ListSaleCard";
import { validateCpf } from "../../utils/validateCpf";

export function SearchByCpf() {
  const [cpf, setCpf] = useState("");
  const [product, setProduct] = useState("");
  const [dataExpenses, setDataExpenses] = useState<SaleDTO[]>([]);
  const [total, setTotal] = useState<number | null>(null);
  const [sum, setSum] = useState<number | null>(null);

  async function handleSearchSpending() {
    if (!cpf || !product) {
      return Alert.alert(
        "Pesquisa de Vendas",
        "Insira ao menos o cpf e produto!"
      );
    }

    if (!!cpf && !validateCpf(cpf)) {
      return Alert.alert("CPF inválido!", "Digite um CPF válido.");
    }

    const data = await getAllSales();

    const newData = data.filter(
      (item) =>
        (cpf.trim() !== "" && item.cpf === cpf.trim()) ||
        (product.trim() !== "" &&
          item.product.toLowerCase().includes(product.trim().toLowerCase()))
    );

    const sum = newData.reduce((total, item) => total + item.value, 0);
    const total = newData.length;

    setSum(sum);
    setTotal(total);
    setDataExpenses(newData);
    setCpf("");
    setProduct("");
  }

  const getTotalResults = () => {
    if (!!total) {
      return <TextCard>{`Total de ${total} resultados encontrados.`}</TextCard>;
    }

    return null;
  };

  const getTotalValue = () => {
    if (!!sum && sum > 0) {
      return <TextCard>{`Valor Total de Vendas: R$ ${sum}`}</TextCard>;
    }

    return null;
  };

  const getList = () => {
    if (!!dataExpenses && dataExpenses.length > 0) {
      return (
        <Transactions>
          <FlatList
            data={dataExpenses}
            renderItem={({ item }) => <ListSaleCard data={item} />}
            showsVerticalScrollIndicator={false}
          />
        </Transactions>
      );
    }

    return null;
  };

  return (
    <TouchableWithoutFeedback onPress={Keyboard.dismiss} accessible={false}>
      <Container>
        <Header title="Consulta" />

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

        <Button title="Pesquisa" onPress={handleSearchSpending} />

        {getTotalResults()}
        {getTotalValue()}
        {getList()}
      </Container>
    </TouchableWithoutFeedback>
  );
}
