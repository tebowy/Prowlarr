import React from 'react';
import Label from 'Components/Label';
import styles from './ProtocolLabel.css';

interface ProtocolLabelProps {
  protocol: string;
}

function ProtocolLabel(props: ProtocolLabelProps) {
  const { protocol } = props;

  const protocolName = protocol === 'usenet' ? 'nzb' : protocol;

  return <Label className={styles[protocol]}>{protocolName}</Label>;
}

export default ProtocolLabel;
