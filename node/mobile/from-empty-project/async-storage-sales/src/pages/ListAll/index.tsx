import React, { useState, useCallback } from "react";
import { useFocusEffect } from "@react-navigation/native";
import { Header } from "../../components/Header";
import { FlatList } from "react-native";
import { Container, Transactions } from "./styles";
import { ListSaleCard } from "../../components/ListSaleCard";
import { getAllSales } from "../../storage/sales/getAllSales";
import { SaleDTO } from "../../storage/sales/SaleDTO";

export function ListALl() {
  const [dataExpenses, setListExpenses] = useState<SaleDTO[]>([]);

  async function loadData() {
    const data = await getAllSales();
    setListExpenses(data);
  }

  useFocusEffect(
    useCallback(() => {
      loadData();
    }, [])
  );

  return (
    <Container>
      <Header title="Listagem de Vendas" />

      <Transactions>
        <FlatList
          data={dataExpenses}
          renderItem={({ item }) => <ListSaleCard data={item} />}
          showsVerticalScrollIndicator={false}
        />
      </Transactions>
    </Container>
  );
}
