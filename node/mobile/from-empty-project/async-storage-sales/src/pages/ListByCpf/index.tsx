import React, { useState, useCallback } from "react";
import { useFocusEffect } from "@react-navigation/native";
import { Header } from "../../components/Header";
import { FlatList } from "react-native";
import { Container, Transactions } from "./styles";
import { getAllSales } from "../../storage/sales/getAllSales";
import { SaleCard } from "../../components/SaleCard";
import { validCpfs } from "../../utils/validateCpf";

type SaleView = {
  cpf: string;
  salesValue: number;
  comission: number;
  salesQuantity: number;
  inss: number;
  liquidSalary: number;
  salary: number;
};

export function ListByCpf() {
  const [dataExpenses, setListExpenses] = useState<SaleView[]>([]);

  async function loadDataSpending() {
    const data = await getAllSales();

    const arr = validCpfs.map((cpf) => {
      const filteredData = data.filter((d) => d.cpf === cpf);
      const salesValue = filteredData.reduce((total, d) => total + d.value, 0);
      const salesQuantity = filteredData.length;

      const comission = filteredData.reduce((total, d) => {
        if (d.value < 100000) {
          return total + d.value * 0.01;
        } else if (d.value < 200000) {
          return total + d.value * 0.02;
        } else if (d.value < 300000) {
          return total + d.value * 0.03;
        } else {
          return total + d.value * 0.05;
        }
      }, 0);

      const salary = 1300;
      const inss = (salary + comission) * 0.08;
      const liquidSalary = salary + comission - inss;

      return {
        cpf,
        salesValue,
        comission,
        salesQuantity,
        inss,
        liquidSalary,
        salary,
      };
    });

    setListExpenses(arr);
  }

  useFocusEffect(
    useCallback(() => {
      loadDataSpending();
    }, [])
  );

  return (
    <Container>
      <Header title="Listagem de Vendas por CPF" />

      <Transactions>
        <FlatList
          data={dataExpenses}
          renderItem={({ item }) => <SaleCard data={item} />}
          showsVerticalScrollIndicator={false}
        />
      </Transactions>
    </Container>
  );
}
