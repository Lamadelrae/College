import { TouchableOpacityProps } from 'react-native'

import {
    Container,
    TextTitle,
    TextCard
} from './styles'

interface ListInvoiceProps {
    id: string,
    description: string,
    invoice_value: string,
    issue_Date: Date,
    client: string,
}

interface ListCardProps extends TouchableOpacityProps {
    item: ListInvoiceProps;
}

export function ListCard({ item, ...rest }: ListCardProps) {
    return (
        <Container
            {...rest}
            key={item.id}>
            <TextTitle>Dados da Nota Fiscal</TextTitle>
            <TextCard>Descrição do Serviço: Alongamento de Chassi</TextCard>
            <TextCard>Valor da NF: R$ 10.000,00</TextCard>
            <TextCard>Data da NF: 21/11/2022</TextCard>
            <TextCard>Cliente: ABC Vendas</TextCard>
        </Container>
    )
}


