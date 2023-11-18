import React from "react";
import {
  Container,
  Description,
  Amount,
  Footer,
  Category,
  Date,
} from "./styles";

import { SaleDTO } from "../../storage/sales/SaleDTO";
type Props = {
  data: SaleDTO;
};

export function ListSaleCard({ data }: Props) {
  return (
    <Container>
      <Description>{data.product}</Description>
      <Amount>${data.value}</Amount>
      <Footer>
        <Category>CPF: {data.cpf}</Category>
        <Date>{data.date}</Date>
      </Footer>
    </Container>
  );
}
